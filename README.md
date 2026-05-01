# SignMe Egypt National ID OCR API

Extract data from Egyptian National ID cards using a high-accuracy OCR API built for KYC, onboarding, and identity verification systems.

---

## 🚀 Overview

SignMe provides a powerful OCR API specialized in reading **Egyptian National ID cards**, driver licenses, vehicle licenses, and passports with near human-level accuracy.

Designed for:
- Fintech & KYC
- Identity verification
- Visitor management systems
- Enterprise onboarding

---

## 🎯 Supported Documents

- 🇪🇬 Egyptian National ID (Front & Back)
- 🚗 Driver License
- 🚘 Vehicle License
- 🛂 Passport / Residency Permit

---

## ✨ Features

- ✅ High-accuracy OCR (Arabic & English)
- ✅ Structured JSON output
- ✅ Fast and scalable API
- ✅ Real-time & batch processing
- ✅ Easy integration (REST API)

---

## ⚡ API Workflow

1. Upload image  
2. Receive processing ID  
3. Poll until OCR data is ready  

---

## 💻 C# Example

```csharp
using System.Net.Http.Headers;
using System.Text.Json;

const string BASE = "https://mobapi.signme.it/api/v2/SignMeAPI";

// idType: 0 = National ID front / Driver / Car License (default)
//         1 = National ID back
//         2 = Passport / Resident Permit
async Task<JsonElement> ExtractIdAsync(string apiKey, string imagePath, int idType = 0)
{
    using var http = new HttpClient();
    http.DefaultRequestHeaders.Add("APIKEY", apiKey);

    // Step 1: Upload
    using var form = new MultipartFormDataContent();
    var bytes = await File.ReadAllBytesAsync(imagePath);
    var img   = new ByteArrayContent(bytes);
    img.Headers.ContentType = MediaTypeHeaderValue.Parse("image/jpeg");
    form.Add(img, "file", Path.GetFileName(imagePath));

    var uploadRes  = await http.PostAsync($"{BASE}/uploadImage?ID_type={idType}", form);
    using var uploadDoc = JsonDocument.Parse(
        await uploadRes.Content.ReadAsStringAsync());
    var id = uploadDoc.RootElement.GetProperty("id").GetString();

    // Step 2: Poll until data is ready
    await Task.Delay(2000);
    for (int i = 0; i < 12; i++)
    {
        var readRes = await http.GetAsync(
            $"{BASE}/ReadImage?id={id}&isBlocked=false");
        using var readDoc = JsonDocument.Parse(
            await readRes.Content.ReadAsStringAsync());
        var data = readDoc.RootElement.GetProperty("data");
        if (data.ValueKind == JsonValueKind.Object &&
            data.EnumerateObject().Any())
            return data.Clone();
        await Task.Delay(1500);
    }
    throw new TimeoutException("OCR processing timed out.");
}

// Usage:
var data = await ExtractIdAsync("YOUR_API_KEY", "national_id.jpg", idType: 0);
Console.WriteLine(data.GetProperty("firstname").GetString());

```

## 📄 Example API Response

```json
{
  "code": 200,
  "status": "success",
  "message": "Successful.",
  "data": {
    "firstname": "محمود",
    "lastname": "عماد حسنين حسين احمد",
    "national_ID": "29612160101819",
    "birthday": "16/12/1996",
    "gender": "ذكر",
    "city": "القاهرة",
    "address1": "ق 5217 هضبه وسطي المقطم القاهره",
    "address2": "",
    "religion": "",
    "status": "",
    "job": "",
    "issueDate": "",
    "expiry": "",
    "releseCity": "",
    "platenumber": "",
    "passportType": "",
    "gender_2": "",
    "proccesstime": "29/04/2026 23:49:26:4926",
    "imageName": "490131.png",
    "savedImage": "290426\\2349264926.jpg",
    "urlImage": null
  }
}
```

## 📊 Extracted Fields
First Name (Arabic)
Last Name (Full Name)
National ID Number
Date of Birth
Gender
City
Address
Optional fields (job, religion, issue date, etc.)

## ❓ FAQ
How to read Egyptian National ID using API?
Upload the ID image using /uploadImage, then call /ReadImage to retrieve OCR results.

## What is idType?
Value	Document Type
0	National ID (front), Driver License, Car License
1	National ID (back)
2	Passport / Residency

## Does it support Arabic text?
Yes — full support for Arabic names, addresses, and fields.

## Is it suitable for KYC?
Yes — designed for fintech, banks, and onboarding systems.

## 🔐 Security
HTTPS encrypted communication
No data stored without permission
Designed for enterprise-grade environments

## 🧠 About SignMe
SignMe is developed by Golden Developer Technology Systems, delivering OCR and identity solutions since 2009 for government, banking, and enterprise sectors.

## 📈 Keywords & Use Cases
SignMe is designed for Egyptian National ID OCR API use cases, including ID card data extraction, KYC automation in Egypt, identity verification systems, and passport OCR solutions.

It supports reading Egyptian ID cards in Arabic and English, making it ideal for fintech, banking, and onboarding applications.

📬 Contact
🌐 https://api.signme.it
📧 info@goldendeveloper.net
