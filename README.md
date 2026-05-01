# SignMe Egypt National ID OCR API

Extract data from Egyptian National ID cards using a high-accuracy OCR API built for KYC, onboarding, and identity verification systems.

---

## 🚀 Overview
SignMe provides a powerful OCR API specialized in reading **Egyptian National ID cards** with near human-level accuracy.  
It is designed for businesses that need fast, reliable, and automated identity data extraction.

---

## 🎯 Use Cases
- 🏦 Banking & Fintech (KYC / onboarding)
- 🏨 Hotels & visitor registration
- 🏢 Corporate security & access control
- 🏥 Hospitals & patient registration
- 📱 Mobile apps requiring identity verification

---

## ✨ Features
- ✅ High-accuracy OCR for Egyptian National ID
- ✅ Extracts structured data (Arabic & English)
- ✅ Fast API response time
- ✅ JSON output ready for integration
- ✅ Supports real-time and batch processing
- ✅ Built for scalability and enterprise use

---

## 📄 Supported Data Extraction
The API can extract:
- Full Name
- National ID Number
- Date of Birth
- Gender
- Address
- Expiry Date
- Face Image (optional)

---
## ⚡ Quick Start

### 1. Get API Key
Sign up and get your API key from:

👉 https://api.signme.it

---

### 2. Example Request (cURL)
```bash
curl -X POST "https://api.signme.it/ocr/egypt-id" \
  -H "Authorization: Bearer YOUR_API_KEY" \
  -F "file=@id-card.jpg"
