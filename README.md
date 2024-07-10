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

## Default
![Ekran görüntüsü 2024-07-11 015317](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/3c54d2d5-8236-4420-9e8c-10989e721151)
![Ekran görüntüsü 2024-07-11 015338](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/e02185fb-2799-4374-abd3-f7928be49263)
![Ekran görüntüsü 2024-07-11 015403](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/455a4e5c-94a9-42e6-b160-86abe0465b37)
![Ekran görüntüsü 2024-07-11 015417](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/ded93c20-9bae-4567-8c1b-d918193218ab)
![Ekran görüntüsü 2024-07-11 015443](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/3266fae0-2b3f-4b59-9a34-5cb60525e852)
![Ekran görüntüsü 2024-07-11 015158](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/03dbe6a7-241a-470a-a532-6cea4ef72f44)
## Swagger
![Ekran görüntüsü 2024-07-11 015216](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/39b355c5-d05d-4737-99b4-f1162848344e)

## Rotation
![Ekran görüntüsü 2024-07-11 015848](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/1eb06f56-a512-4473-b2ca-00ad94c01c4b)
![Ekran görüntüsü 2024-07-11 015941](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/2cf01b72-b854-4724-8d05-f88d8224fe1d)
![Ekran görüntüsü 2024-07-11 020002](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/c72b0ba5-7e6d-4f42-b222-5a4c184d7825)
![Ekran görüntüsü 2024-07-11 020105](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/a078298b-cc61-4c86-8da6-4f0e9e9a7b28)
![Ekran görüntüsü 2024-07-11 020128](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/e5bd21b2-c420-47fa-a76e-90b9c6198c14)
![Ekran görüntüsü 2024-07-11 020153](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/f2c1a872-e484-4149-9e55-c9b49da35cf5)


## Admin
![Ekran görüntüsü 2024-07-11 021011](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/293a5e58-04b0-4532-a079-b84a7f20efaa)
![Ekran görüntüsü 2024-07-11 021027](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/38f48e96-89d0-4bd8-a689-5b00660de21e)
![Ekran görüntüsü 2024-07-11 021047](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/c7bd7e70-3d92-4e97-993b-904e563a060a)
![Ekran görüntüsü 2024-07-11 021100](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/40dc3d55-3200-4521-ad82-1a6c133412a4)
![Ekran görüntüsü 2024-07-11 021112](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/592e110b-47dd-4c85-a1f6-e243d47a26af)
![Ekran görüntüsü 2024-07-11 021123](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/633cff08-991d-45b0-9bc7-e7223328b6b5)
![Ekran görüntüsü 2024-07-11 021135](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/e04f0fbc-7fb9-49be-a842-2df2ccce6fb2)
![Ekran görüntüsü 2024-07-11 021144](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/2737829f-bb48-4bc1-8c31-cb29952f4d23)
![Ekran görüntüsü 2024-07-11 021153](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/a524d06c-5333-40dc-94f3-4d096df87327)
![Ekran görüntüsü 2024-07-11 021211](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/02bc2eab-9a74-49e8-941a-959d033281ea)
![Ekran görüntüsü 2024-07-11 021221](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/86524cfd-9cc0-4646-b4e3-e3726aeee0c3)
![Ekran görüntüsü 2024-07-11 021233](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/22916f43-e155-4d54-99de-2064b62f265f)
![Ekran görüntüsü 2024-07-11 021242](https://github.com/kkelesyusuf23/TravelProject/assets/148692615/3a54d224-7738-488c-8378-ad77c259c321)

















