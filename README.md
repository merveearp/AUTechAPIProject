# 🚀 AUTech API Project

![.NET](https://img.shields.io/badge/.NET-8.0-purple?style=for-the-badge&logo=dotnet)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-API-blue?style=for-the-badge&logo=dotnet)
![JWT](https://img.shields.io/badge/JWT-Authentication-green?style=for-the-badge&logo=jsonwebtokens)
![FluentValidation](https://img.shields.io/badge/FluentValidation-Validation-success?style=for-the-badge)
![Mapster](https://img.shields.io/badge/Mapster-Object%20Mapping-blue?style=for-the-badge)
![Gemini](https://img.shields.io/badge/Gemini-AI-orange?style=for-the-badge&logo=google)

---

## 📌 Proje Hakkında

**AUTech API Project**, modern yazılım ihtiyaçlarını karşılamak üzere geliştirilmiş,  
tamamen **dinamik**, **katmanlı mimariye sahip** bir **ASP.NET Core Web API** projesidir.

Proje aşağıdaki bileşenlerden oluşur:

- API
- Admin Panel
- Web UI template alanı

Web UI üzerinde görünen tüm içerikler,  
**Admin Panel üzerinden dinamik olarak yönetilmektedir**.

---

## 🧱 Mimari Yapı

Proje, **N-Katmanlı Mimari (N-Tier Architecture)** yaklaşımıyla geliştirilmiştir.

### Katmanlar

- **Entity (Core) Layer**
  - Domain nesneleri ve temel entity tanımları

- **DTO (Data Transfer Object) Layer**
  - Katmanlar arası veri transferi
  - API request / response modelleri

- **Data Access Layer**
  - Entity Framework Core ile veritabanı işlemleri

- **Business Layer**
  - İş kuralları
  - Servis mantığı
  - Validation ve mapping süreçleri

- **API Layer**
  - Endpoint tanımları
  - Authentication süreçleri

- **Admin UI**
  - Web UI içeriklerinin tamamının yönetildiği panel

- **Web UI**
  - Son kullanıcıya sunulan arayüz

---

## 🔄 Object Mapping (Mapster)

Projede **DTO ↔ Entity** dönüşümleri için **Mapster** kullanılmıştır.

Mapster tercih edilme nedenleri:

- Manuel mapping kodlarını azaltmak
- Daha performanslı mapping altyapısı sağlamak
- Business katmanında temiz ve okunabilir servisler oluşturmak

---

## 🔐 Kimlik Doğrulama & Güvenlik

- JWT (JSON Web Token) tabanlı authentication uygulanmıştır
- API endpoint’lerine güvenli erişim sağlanmaktadır
- Projede role-based authorization **kullanılmamıştır**
- Authentication yapısı, proje kapsamı doğrultusunda **bilinçli olarak sade tutulmuştur**

---

## ✅ Veri Doğrulama (FluentValidation)

Projede **FluentValidation** kullanılarak:

- DTO’lar üzerinden merkezi validation sağlanmıştır
- Controller katmanı sade tutulmuştur
- Validation kuralları Business katmanına entegre edilmiştir

---

## 🤖 Yapay Zekâ Entegrasyonu (Gemini)

Projeye **Google Gemini AI** entegre edilmiştir.

Gemini robotu:

- Kullanıcıları mevcut içerik hakkında bilgilendirir
- İçeriğin yetersiz kaldığı durumlarda AI ile etkileşime yönlendirir
- Daha etkileşimli bir kullanıcı deneyimi sunar

---

## 🎛️ Admin Panel

Admin panel üzerinden:

- Web UI içerikleri tamamen dinamik olarak yönetilir
- Sayfalar ve alanlar merkezi bir panelden kontrol edilir
- AI destekli alanlar yönetilebilir

---

## 🛠️ Kullanılan Teknolojiler

- ASP.NET Core 8.0
- Web API
- Entity Framework Core
- JWT Authentication
- FluentValidation
- Mapster
- DTO Pattern
- Google Gemini AI
- N-Tier Architecture
- Admin Panel & Web UI Template
- RESTful API prensipleri

---

## 👩‍💻 Geliştirici

**Merve Arpacıoğlu**  
.NET | Web API | AI Entegrasyonları | Katmanlı Mimari 
Projenin Admin Panel ve Web UI tarafına ait ekran görüntüleri aşağıda yer almaktadır.

![WEBUI1](https://github.com/user-attachments/assets/caf25cc1-d760-490e-b9de-b3e7aef55f2e)
![WEBUI2](https://github.com/user-attachments/assets/41723f6d-3932-4ff5-987a-2ec1599e87be)
![WEBUI3](https://github.com/user-attachments/assets/d2af52bd-51dd-47fb-b773-dd2be6a9fcb7)
![WEBUI5](https://github.com/user-attachments/assets/155ddc23-ae00-44c0-bdd8-17ff4a8d9d0d)
![WEBUI4](https://github.com/user-attachments/assets/e9ec3956-3982-4a24-ae5d-a6abf44eca17)
![REGİSTER1](https://github.com/user-attachments/assets/ec18cdef-b4aa-4dc6-8270-445f65f2bbd2)
![LOGIN1](https://github.com/user-attachments/assets/337db243-2e59-40a3-a8ab-3cad81510362)
![ADM6](https://github.com/user-attachments/assets/7aef8580-d74b-4002-8601-e1ba0848edde)
![ADM5](https://github.com/user-attachments/assets/a79e24a8-a0ec-402e-9536-a15922554906)
![ADM4](https://github.com/user-attachments/assets/e385315a-b624-40c7-8e0f-9a4b0c8c1cca)
![ADM3](https://github.com/user-attachments/assets/f01c8bb5-75a4-4dc6-a013-d0d8dd094a86)
![ADM2](https://github.com/user-attachments/assets/79188dd2-a62d-476f-8003-0e0fadf9e605)
![ADM1](https://github.com/user-attachments/assets/07a5fd54-9427-4a38-bfcf-eefd022c1adb)



