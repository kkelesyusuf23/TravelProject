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

- **UI (Kullanıcı Arayüzü)**: Şehir içi gezi rotalarını, lokasyonları ve diğer bilgileri görüntüleyin.
- **Admin Paneli**: Yönetimsel işlemler için ayrı bir arayüz sağlar. Rotalar, lokasyonlar ve diğer yönetimsel veriler burada eklenir, güncellenir ve silinir.



