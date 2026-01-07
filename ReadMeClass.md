# SWE201_235060003FINAL – Gym Management App

Bu depo **SWE201_235060003FINAL** adlı proje, **SWE201 Object Oriented Programming** dersinde geliştirilmiş bir C# konsol uygulamasıdır. Proje, basit bir spor salonu yönetim sistemi (Gym Management App) örneği olarak tasarlanmış ve ders kapsamında geliştirilme adımlarıyla birlikte hazırlanmıştır.

---

## Proje Hakkında

Gym Management App, bir spor salonu yönetim uygulamasıdır. Kullanıcıların üyelik bilgilerini, eğitmenleri ve üyelik türlerini modelleyen sınıflar ile temel yönetim işlemlerini gerçekleştirebileceğiniz bir C# konsol projesidir.

---

## Geliştirme Adımları

Projenin geliştirilmesi aşağıdaki adımlarla gerçekleştirilmiştir:

1. **Proje Oluşturma**
   - Visual Studio veya benzeri bir IDE kullanılarak C# Console App projesi oluşturuldu.
   - Proje adı olarak `SWE201_235060003FINAL` belirlendi.

2. **Sınıf Tabanlı Tasarım**
   - Programın objelerine karşılık gelen 3 ana sınıf tasarlandı:
     - `Member.cs` – Spor salonu üyelerini temsil eder.
     - `Trainer.cs` – Eğitmen bilgilerini tutar.
     - `Membership.cs` – Üyelik türlerini (ör. aylık, yıllık) ve ücretleri içerir.
   - Tüm sınıflar **Single Responsibility Principle** (Tek Sorumluluk İlkesi) esasına göre ayrı dosyalarda tutuldu ve kod okunabilirliğini artırdı.

3. **Ana Program Akışı**
   - `Program.cs` dosyası içine uygulamanın ana akışı yazıldı.
   - Kullanıcıdan giriş veya seçim alacak şekilde temel işlemler eklendi.
   - Üyelik ve eğitmen bilgileri ile sistemin çalışması sağlandı.

4. **Kod Test ve Çalıştırma**
   - Proje derlenip çalıştırıldı.
   - Oluşan hatalar gözden geçirilerek düzenlemeler yapıldı.
   - Kodun düzgün şekilde çalıştığı test edildi.

---

## Uygulama Özellikleri

- Basit konsol tabanlı kullanıcı arayüzü.
- Temel nesne-yönelimli sınıf yapısı ile tanımlı modeller.
- Üyelik, eğitmen ve üyelik türleri için sınıf tasarımı.
- Sınıflar arası ilişki ve veri kullanım örneği.
