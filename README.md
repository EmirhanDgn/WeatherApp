# WeatherApp
WeatherApp, kullanıcının konumunu otomatik olarak belirleyerek ve belirli bir şehir/ülke için hava durumu verilerini gösteren bir ASP.NET Core MVC uygulamasıdır. Bu uygulama, bir form aracılığıyla manuel olarak da şehir/ülke bilgisi girilmesine olanak tanır ve hava durumu bilgilerini dinamik olarak günceller.

## Özellikler
Kullanıcının konumunu otomatik olarak belirler.
Kullanıcının girdiği şehir ve ülke bilgilerine göre hava durumu verilerini getirir.
Hava durumu bilgilerine göre arka plan resmini dinamik olarak değiştirir.
Kullanıcının konumunu yalnızca bir kez alır ve sonraki ziyaretlerde aynı işlemi tekrarlamaz.

## Kullanılan Teknolojiler
- ASP.NET Core MVC
- C#
- JavaScript (Geolocation API)
- HTML5
- CSS3

## Proje Yapısı
- Models/WeatherModel.cs:
- Hava durumu verilerini taşıyan model sınıfı.
- Services/WeatherService.cs:
- Hava durumu API'sine istek gönderen ve verileri çeken servis sınıfı.
- Controllers/HomeController.cs:
- Hava durumu verilerini işleyen ve View'a gönderen controller sınıfı.
- Views/Home/Index.cshtml:
- Kullanıcı arayüzü, form ve hava durumu bilgilerini gösteren Razor view dosyası.
