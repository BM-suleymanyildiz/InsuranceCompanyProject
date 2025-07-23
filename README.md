# 🛡️ InsuranceCompanyProject – AI Destekli Sigorta Web Uygulaması 

**InsuranceCompanyProject**, ASP.NET MVC 5 ve Entity Framework (DB-First) mimarisi ile geliştirilmiş, yapay zeka destekli modern bir sigorta firması yönetim platformudur.  
Proje, hem içerik yöneticilerine sezgisel bir admin paneli sunar hem de kullanıcı tarafında modern, görsel ve etkileşimli bir deneyim sağlar.

---

## 📌 Genel Özellikler

### 🎛️ Admin Paneli
- **Yapay zeka destekli SSS yönetimi:**  
  Admin, bir konu girerek OpenAI (ChatGPT API - RapidAPI) üzerinden benzer sorular oluşturur, ardından her biri için otomatik cevap alabilir.
- **AI tabanlı görsel üretimi:**  
  Her hizmet için Hugging Face (via `text-to-image`) API'siyle otomatik görseller oluşturulur ve projeye dahil edilir.
- İçerik yönetimi (CRUD):
  - Hizmetler
  - Slider öğeleri
  - Referanslar
  - Çalışanlar
  - Hakkımızda
  - İletişim bilgileri

### 🌐 Kullanıcı Arayüzü
- **Responsive ve modern arayüz:**  
  Bootstrap 5 ile geliştirilmiş, mobil uyumlu ve kullanıcı dostu bir tasarım.
- **Dinamik SSS (FAQ) bölümü:**  
  Accordion yapı kullanılarak oluşturulmuş, içerikleri admin tarafından otomatik oluşturulabilir.
- **Görsellerle desteklenen hizmetler sayfası**
- **Kurumsal sayfalar:**  
  Referanslar, Hakkımızda, Çalışanlar ve İletişim gibi bölümler
- **Sosyal medya takipçi sayısı gösterimi:**  
  Instagram ve LinkedIn takipçi sayıları, API üzerinden çekilerek **kullanıcı arayüzünde** gösterilir (admin panelinden yönetilmez).

### 🌍 i18n Localization
- **Türkçe ve İngilizce** dilleri desteklenmektedir
- Tüm metin içerikleri `.resx` dosyaları üzerinden yönetilir
- Kullanıcı, arayüz üzerinden dili değiştirebilir
- View ve Controller düzeyinde dil geçişi dinamik olarak yönetilmektedir

---

## 🤖 Yapay Zeka Entegrasyonları

### ✅ ChatGPT API (RapidAPI) ile Soru-Cevap Üretimi
- Kullanıcı belirli bir hizmet konusunu girer
- Sistem, o konuya dair 3 benzer soru üretir
- Her soru için "Cevap oluştur" butonuyla cevap getirilir
- Soru ve cevaplar veritabanına kaydedilir

### 🎨 Hugging Face API ile Görsel Üretimi
- Kullanıcı, bir hizmete dair kısa bir açıklama yazar (örneğin: "Sağlık Sigortası")
- Hugging Face `text-to-image` modeli (örneğin `SG161222/Realistic_Vision`) ile uygun bir görsel üretilir
- Görsel `Content/AiImages/` klasörüne kaydedilir ve hizmet kartına bağlanır

---

## ⚙️ Kullanılan Teknolojiler

| Teknoloji                  | Açıklama                                      |
|---------------------------|-----------------------------------------------|
| **ASP.NET MVC 5**         | Web uygulaması çatısı                         |
| **Entity Framework (DB-First)** | Mevcut SQL veritabanından model üretimi      |
| **Microsoft SQL Server**  | Veritabanı yönetimi                           |
| **Bootstrap 5**           | Responsive tasarım                            |
| **jQuery**                | Dinamik UI etkileşimleri                      |
| **ChatGPT API (RapidAPI)**| AI ile soru-cevap üretimi                     |
| **Hugging Face API**      | AI ile görsel üretimi                         |
| **Instagram & LinkedIn API (RapidAPI)** | Takipçi sayısı çekme (kullanıcı arayüzü için) |
| **C#**                    | Backend geliştirme dili                       |

---

## 📸 Ekran Görüntüleri

<img width="2560" height="4838" alt="screencapture-localhost-44313-Default-Index-2025-07-23-21_48_42" src="https://github.com/user-attachments/assets/262832fd-e497-4881-ad9a-c6c00105e2aa" />

<img width="376" height="76" alt="Ekran görüntüsü 2025-07-20 171543" src="https://github.com/user-attachments/assets/6c8b12a1-8f53-4495-ae90-0198e4e6d0f3" />

<img width="377" height="72" alt="Ekran görüntüsü 2025-07-20 171549" src="https://github.com/user-attachments/assets/bc4e3316-39af-484f-b67d-c5f4eb3ee268" />

<img width="1428" height="775" alt="Ekran görüntüsü 2025-07-23 215541" src="https://github.com/user-attachments/assets/20deac77-d74d-4c4f-9a3f-82e2b192b8de" />

<img width="995" height="802" alt="Ekran görüntüsü 2025-07-23 214549" src="https://github.com/user-attachments/assets/a6ebe4b5-ef67-4a98-b8a4-f23fa96addc7" />

<img width="1899" height="599" alt="Ekran görüntüsü 2025-07-23 215601" src="https://github.com/user-attachments/assets/2defc50d-ea2c-45bb-82fb-f67f367bf838" />

<img width="1919" height="903" alt="Ekran görüntüsü 2025-07-23 215419" src="https://github.com/user-attachments/assets/d58d89c0-dc07-4018-81c6-88be2543a21c" />

<img width="1919" height="658" alt="Ekran görüntüsü 2025-07-23 215059" src="https://github.com/user-attachments/assets/a7a20cbc-f534-4865-a5b6-a3143f913e43" />

<img width="1919" height="648" alt="Ekran görüntüsü 2025-07-23 215120" src="https://github.com/user-attachments/assets/8308cb57-5ced-4e62-9526-7a4b8c815e6a" />

<img width="1919" height="639" alt="Ekran görüntüsü 2025-07-23 215202" src="https://github.com/user-attachments/assets/f78f5170-a2b4-4393-86ad-3e694f6af24c" />

<img width="1918" height="642" alt="Ekran görüntüsü 2025-07-23 215233" src="https://github.com/user-attachments/assets/1f3684d0-464f-48c0-9901-3827126b3f82" />

<img width="1919" height="638" alt="Ekran görüntüsü 2025-07-23 215316" src="https://github.com/user-attachments/assets/215088f1-4c3b-4a06-b4d1-38f703db6cfd" />

<img width="1298" height="803" alt="Ekran görüntüsü 2025-07-23 215332" src="https://github.com/user-attachments/assets/4f90162c-d946-4dd4-96ed-3be70691c282" />

<img width="1919" height="903" alt="Ekran görüntüsü 2025-07-23 215419" src="https://github.com/user-attachments/assets/1538477b-7316-4fab-bfd4-3cea98e99249" />

<img width="1919" height="657" alt="Ekran görüntüsü 2025-07-23 215443" src="https://github.com/user-attachments/assets/0c7f3145-a2e8-469b-b8bb-1520c21051c7" />



---

## 🧑‍💻 Geliştirici

**Süleyman Yıldız**  
📫 [LinkedIn](https://www.linkedin.com/in/suleyman--yildiz/)  
📧 Email: suleymanyildiz491@gmail.com  

---
