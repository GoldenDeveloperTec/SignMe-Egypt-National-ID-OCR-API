using System.Text.Json.Serialization;

namespace SignMeSample;

public record UploadResponse(
    [property: JsonPropertyName("code")]    int    Code,
    [property: JsonPropertyName("status")]  string Status,
    [property: JsonPropertyName("message")] string Message,
    [property: JsonPropertyName("id")]      string Id
);

public record ReadResponse(
    [property: JsonPropertyName("code")]    int     Code,
    [property: JsonPropertyName("status")]  string  Status,
    [property: JsonPropertyName("message")] string  Message,
    [property: JsonPropertyName("data")]    IdData? Data
);

public record IdData(
    [property: JsonPropertyName("firstname")]   string Firstname,
    [property: JsonPropertyName("lastname")]    string Lastname,
    [property: JsonPropertyName("address1")]    string Address1,
    [property: JsonPropertyName("address2")]    string Address2,
    [property: JsonPropertyName("national_ID")] string NationalId,
    [property: JsonPropertyName("birthday")]    string Birthday,
    [property: JsonPropertyName("city")]        string City,
    [property: JsonPropertyName("gender")]      string Gender,
    [property: JsonPropertyName("religion")]    string Religion,
    [property: JsonPropertyName("job")]         string Job,
    [property: JsonPropertyName("issueDate")]   string IssueDate,
    [property: JsonPropertyName("expiry")]      string Expiry
);
