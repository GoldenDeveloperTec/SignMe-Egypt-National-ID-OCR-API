using System.Net.Http.Headers;
using System.Text.Json;

namespace SignMeSample;

public sealed class SignMeClient : IDisposable
{
    private readonly HttpClient _http = new();
    private const string BaseUrl = "https://mobapi.signme.it/api/v2/SignMeAPI";
    private static readonly JsonSerializerOptions JsonOpts = new() { PropertyNameCaseInsensitive = true };

    public SignMeClient(string apiKey)
    {
        _http.DefaultRequestHeaders.Add("APIKEY", apiKey);
        _http.DefaultRequestHeaders.ExpectContinue = false;
        _http.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");
        _http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("*/*"));
        _http.Timeout = TimeSpan.FromSeconds(30);
    }

    /// <summary>Upload a national ID image and return the processing job ID.</summary>
    public async Task<UploadResponse> UploadImageAsync(string filePath, int idType = 0)
    {
        using var form = new MultipartFormDataContent();

        var bytes = await File.ReadAllBytesAsync(filePath);
        var fileContent = new ByteArrayContent(bytes);
        fileContent.Headers.ContentType = new MediaTypeHeaderValue(GetMimeType(filePath));
        form.Add(fileContent, "file", Path.GetFileName(filePath));

        var response = await _http.PostAsync($"{BaseUrl}/uploadImage?ID_type={idType}", form);
        return await DeserializeOrThrow<UploadResponse>(response, "upload");
    }

    /// <summary>Fetch the extracted data for a previously uploaded image.</summary>
    public async Task<ReadResponse> ReadImageAsync(string id)
    {
        var response = await _http.GetAsync($"{BaseUrl}/ReadImage?id={id}&isBlocked=false");
        return await DeserializeOrThrow<ReadResponse>(response, "read");
    }

    private static async Task<T> DeserializeOrThrow<T>(HttpResponseMessage response, string operation)
    {
        var body = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            var hint = response.StatusCode switch
            {
                System.Net.HttpStatusCode.Unauthorized  => " – check your API key.",
                System.Net.HttpStatusCode.Forbidden     => " – API key rejected or quota exceeded.",
                System.Net.HttpStatusCode.NotFound      => " – endpoint not found.",
                _                                       => "."
            };
            throw new InvalidOperationException(
                $"Server returned {(int)response.StatusCode} on {operation}{hint}");
        }

        if (string.IsNullOrWhiteSpace(body))
            throw new InvalidOperationException($"Empty response from server on {operation}.");

        if (!body.TrimStart().StartsWith('{'))
            throw new InvalidOperationException(
                $"Unexpected response (not JSON) on {operation}.\n\nServer said:\n{body[..Math.Min(300, body.Length)]}");

        return JsonSerializer.Deserialize<T>(body, JsonOpts)
               ?? throw new InvalidOperationException($"Could not parse {operation} response.");
    }

    /// <summary>
    /// Poll ReadImage every second until data is ready or the timeout expires.
    /// Throws <see cref="TimeoutException"/> if no result arrives within <paramref name="timeoutSeconds"/>.
    /// </summary>
    public async Task<IdData> PollForResultAsync(string id, int timeoutSeconds = 15,
        IProgress<string>? progress = null)
    {
        var deadline = DateTime.UtcNow.AddSeconds(timeoutSeconds);
        var attempt = 0;

        while (DateTime.UtcNow < deadline)
        {
            attempt++;
            progress?.Report($"Reading result… attempt {attempt}");

            var result = await ReadImageAsync(id);

            if (result.Code == 200 && result.Data != null
                && !string.IsNullOrWhiteSpace(result.Data.NationalId))
                return result.Data;

            await Task.Delay(1000);
        }

        throw new TimeoutException($"No result returned within {timeoutSeconds} seconds.");
    }

    private static string GetMimeType(string path) =>
        Path.GetExtension(path).ToLowerInvariant() switch
        {
            ".png"          => "image/png",
            ".jpg" or ".jpeg" => "image/jpeg",
            ".bmp"          => "image/bmp",
            _               => "application/octet-stream"
        };

    public void Dispose() => _http.Dispose();
}
