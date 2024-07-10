# Şehir İçi Gezi Projesi

Bu proje, Türkiye genelinde şehir içi gezi planlamasını kolaylaştırmayı amaçlayan interaktif bir web uygulamasıdır. Kullanıcılar, harita üzerinde konumları seçebilir, rotalarını oluşturabilir ve bu rotaları Google Haritalar API entegrasyonu ile görselleştirebilir. Ayrıca, kullanıcılar oluşturdukları rotaları kaydedebilir ve yönetebilir.

## Proje Amacı

Bu projenin amacı, şehir içi gezilerin daha verimli ve keyifli hale getirilmesini sağlamaktır. Kullanıcıların harita üzerinde istedikleri konumları seçmelerine, rotalarını oluşturmalarına ve bu rotaları yönetmelerine olanak tanır. Ayrıca, kullanıcılar oluşturdukları rotaları kaydedebilir, güncelleyebilir ve paylaşabilirler.

## Kullanıcı Kategorileri

- **Misafir Kullanıcılar**: Siteyi gezebilir, harita üzerinde rotalar oluşturabilir ve bu rotaları Google Maps üzerinde görselleştirebilir.
- **Giriş Yapmış Kullanıcılar**: Oluşturdukları rotaları kaydedebilir ve daha sonra yönetebilirler.
- **Yönetici Kullanıcılar**: Site yönetim paneli üzerinden tüm veritabanı tabloları için CRUD işlemleri yapabilir ve site içeriğini düzenleyebilirler.

## Kullanılan Teknolojiler

- **ASP.NET Core**: Framework
- **MVC**: Model-View-Controller tasarım deseni
- **Entity Framework Core**: Veri erişim katmanı
- **Bootstrap ve JavaScript**: Kullanıcı arayüzü
- **Google Maps API**: Harita ve rota entegrasyonu
- **Rapid API**: API entegrasyonu

## Proje Mimarisi

Proje, N-tier mimari yapısı üzerine inşa edilmiştir:
- **Presentation**: Kullanıcı arayüzü, ASP.NET Core MVC kullanılarak geliştirilmiştir.
- **Business**: Uygulamanın iş kurallarını ve mantığını içerir.
- **Data Access**: Veritabanı işlemleri gerçekleştirilir.
- **DTO**: Veri transferi için kullanılan nesneleri tanımlar.
- **Entity**: Uygulamanın veri modellerini tanımlar.

## Kullanıcı Arayüzü

## UIDefault

![Ekran görüntüsü 2024-07-11 015158](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/03dbe6a7-241a-470a-a532-6cea4ef72f44)
![Ekran görüntüsü 2024-07-11 015443](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/3266fae0-2b3f-4b59-9a34-5cb60525e852)
![Ekran görüntüsü 2024-07-11 015417](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/ded93c20-9bae-4567-8c1b-d918193218ab)
![Ekran görüntüsü 2024-07-11 015403](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/455a4e5c-94a9-42e6-b160-86abe0465b37)
![Ekran görüntüsü 2024-07-11 015338](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/e02185fb-2799-4374-abd3-f7928be49263)
![Ekran görüntüsü 2024-07-11 015317](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/3c54d2d5-8236-4420-9e8c-10989e721151)
![Ekran görüntüsü 2024-07-11 015216](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/39b355c5-d05d-4737-99b4-f1162848344e)























