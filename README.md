## Proje Tanıtım Videosu
[Video İzle](https://youtu.be/QjOuNX-zlBQ)
# DeepFood Diary Projesi

## Projenin Amacı
Bu uygulama, kullanıcıların günlük beslenme alışkanlıklarını takip etmelerine ve belirli bir hedefe ulaşmalarına yardımcı olur. Kullanıcılar, tükettikleri yiyecekleri kaydedebilir, bu yiyeceklerin kalori değerlerini görebilir ve belirli bir zaman diliminde aldıkları kalori miktarını izleyebilirler. Bu, sağlıklı yaşam sürdürmek veya kilo kontrolü yapmak isteyen kullanıcılar için faydalı olabilir.

## Projenin Kapsamı

### 1. Kullanıcı Yönetimi
- Kullanıcılar sisteme kayıt olabilir ve oturum açabilir.
- Kullanıcı hesaplarının yönetimi `UserManager` sınıfı ile sağlanır.

### 2. Yiyecek Ekleme
- Kullanıcılar tükettikleri yiyecekleri sisteme ekleyebilir.
- Eklenen yiyecekler, veritabanındaki `FoodItem` modeli aracılığıyla saklanır.
- Kullanıcılar, yiyeceklerin porsiyonlarını seçebilir ve ekledikleri yiyeceklerin kalori değerlerini görebilir.

### 3. Raporlama Sistemi
- Kullanıcılar, günlük, haftalık ve aylık bazda aldıkları kalorileri takip edebilir.
- Sistemdeki veriler, `Reports` tablosu üzerinden analiz edilir ve görsel raporlar sunulur.
- En çok tüketilen yiyecekler gibi raporlara ulaşılabilir.

### 4. Şifre Yenileme
- Kullanıcılar şifrelerini unuttuklarında, basit adımlarla şifre yenileme işlemi yapabilirler.
- Şifre yenileme işlemi, `UserManager` sınıfının metotları ile gerçekleştirilir ve güvenlik kodu doğrulaması yapılır.

### 5. Yönetici Paneli
- Yöneticiler, sisteme eklenen yiyecekler ve kategoriler üzerinde tam kontrole sahiptir.
- CRUD işlemleri yapılabilir.

## Teknolojiler

### EF Core (Entity Framework Core)
- **Versiyon:** 6.x
- **Açıklama:** Veritabanı işlemlerini kolaylaştırmak için kullanılan ORM (Nesne-İlişkisel Eşleme) aracıdır.

### AutoMapper
- **Versiyon:** 10.x
- **Açıklama:** Nesneler arası veri aktarımını kolaylaştıran bir haritalama aracıdır. DTO (Data Transfer Object) ve domain modelleri arasında veri dönüşümleri sağlar.

### SQL Server
- **Açıklama:** Uygulamanın veritabanı olarak kullanılır.

### Unit of Work ve Repository Tasarım Deseni
- **Açıklama:** Veritabanı işlemlerini daha modüler hale getiren ve birim bazlı işlemleri yöneten tasarım desenleridir.

## N-Tier Mimarisi
Bu proje, **N-Tier (Katmanlı Mimari)** ile geliştirilmiştir. Aşağıda katmanlar ve işlevleri açıklanmıştır:
  
1. **Business Logic Layer (İş Mantığı Katmanı)**:
    - Veriler üzerinde iş kurallarını uygulayan katmandır.
    - SOLID prensiplerine göre dizayn edilmiştir.
  
2. **Data Access Layer (Veri Erişim Katmanı)**:
    - Veritabanı işlemlerini gerçekleştiren katmandır.
    - **Entity Framework Core** kullanılarak geliştirilmiştir.
  
3. **Entities Layer (Varlık Katmanı)**:
    - Veritabanı tablolarına karşılık gelen sınıfların tanımlandığı katmandır.

4. ## UI (User Interface) Katmanı
UI katmanı, DeepFood Diary uygulamasında kullanıcıların etkileşimde bulunduğu görsel arayüzü sağlar. Bu katmanda kullanıcıların formlar aracılığıyla veri girişini gerçekleştirmesi, kullanıcı detaylarının görüntülenmesi, öğün ve besin kayıtlarının eklenmesi ve düzenlenmesi gibi işlemler yapılır. UI katmanında kullanılan formlar, verileri arka plandaki iş katmanına (business layer) göndererek kullanıcının girdiği bilgileri doğrular ve işleme alır.

### UI Katmanının İşlevleri:
- **Kullanıcı Kayıt ve Giriş Formları:** Kullanıcıların hesap oluşturması ve giriş yapması sağlanır.
- **Öğün ve Besin Takibi Formları:** Kullanıcılar, öğünlerine ekledikleri yiyeceklerin kalori ve besin değerlerini kolayca girebilir.
- **Admin Yönetimi:** Admin kullanıcıları, kullanıcı hesaplarını yönetir ve sistemdeki verileri görüntüleyip düzenleyebilir.
- **Dinamik Veri Görselleştirme:** Kullanıcı detayları ve öğün bilgileri gibi veriler, form alanlarında dinamik olarak sunulur.

UI katmanı, uygulamanın görsel bileşenlerinin yanı sıra, kullanıcı deneyiminin kolaylaştırılması ve doğru veri akışının sağlanması için Bootstrap ve diğer CSS framework'leri ile desteklenmiştir.

  
Bu katmanlı yapı, projenin modüler, bakımı kolay ve ölçeklenebilir olmasını sağlar.

## Kullanılan Design Pattern'ler

### 1. **Repository Pattern**:
   - **Repository Pattern**, veri erişim katmanını soyutlayarak veri işlemlerinin daha kolay yönetilmesini sağlar. Tüm veritabanı işlemleri, bağımsız repository sınıflarında toplanır. Bu proje, Entity Framework ile entegre bir repository yapısı kullanmaktadır.
   
### 2. **Dependency Injection (Bağımlılık Enjeksiyonu)**:
   - Uygulama genelinde bağımlılıkların gevşek bağlanması için **Dependency Injection (DI)** kullanılmıştır. Özellikle iş katmanında (Business Layer) hizmetleri enjekte ederek SOLID prensiplerine uygun bir yapı kurulmuştur.

### 3. **Unit of Work**:
   - Veritabanı işlemlerinin toplu olarak yönetilmesi için **Unit of Work** kullanılmıştır. Bu sayede birden fazla veri işlemi bir transaction içinde ele alınarak tutarlılık sağlanır.

### 4. **Factory Pattern**:
   - Nesnelerin oluşturulmasını kontrol etmek için **Factory Pattern** uygulanmıştır. Özellikle, nesne oluşturma süreçlerinde esneklik sağlamak amacıyla kullanılmıştır.

## SOLID Prensipleri
Bu projede **SOLID** prensiplerine dikkat edilerek modüler ve esnek bir yapı oluşturulmuştur:

1. **S**: Single Responsibility Principle (Tek Sorumluluk Prensibi)
    - Her sınıfın sadece bir sorumluluğu vardır. Örneğin, **UserService** sınıfı sadece kullanıcıyla ilgili iş mantıklarını içerir.
  
2. **O**: Open/Closed Principle (Açık/Kapalı Prensibi)
    - Sınıflar genişletilebilir ancak değiştirilemez. Yeni iş kuralları eklendiğinde mevcut sınıflar üzerinde değişiklik yapılmadan sistem genişletilebilir.
  
3. **L**: Liskov Substitution Principle (Liskov Yerine Geçme Prensibi)
    - Türeyen sınıflar, ana sınıflar yerine kullanılabilir. Örneğin, bir **Admin** sınıfı, bir **BaseUser** sınıfından türeyebilir ve bu yapı bozulmadan kullanılabilir.
  
4. **I**: Interface Segregation Principle (Arayüzlerin Ayrımı Prensibi)
    - Arayüzler, kullanıcı ihtiyaçlarına göre ayrılmıştır. Tek bir arayüz, farklı alanlarda kullanılacak şekilde geniş tutulmamıştır. Kullanıcının ihtiyaç duyduğu kadar fonksiyon sunar.
  
5. **D**: Dependency Inversion Principle (Bağımlılığın Ters Çevrilmesi Prensibi)
    - Yüksek seviyeli modüller, düşük seviyeli modüllere bağımlı değildir. **Dependency Injection** ile bu prensip sağlanmıştır.

## Veritabanı Yapısı

#### Admins Tablosu
| Sütun Adı   | Veri Tipi | Açıklama                     |
|-------------|-----------|------------------------------|
| Id          | int       | Yönetici kimliği (PK)         |
| Password    | string    | Yönetici şifresi              |
| AdminName   | string    | Yönetici adı                  |
| CreatedDate | datetime  | Oluşturulma tarihi            |
| ModifiedDate| datetime  | Güncellenme tarihi            |
| DeletedDate | datetime  | Silinme tarihi                |
| Status      | bool      | Durum (aktif/pasif)           |

#### Users Tablosu
| Sütun Adı    | Veri Tipi | Açıklama                      |
|--------------|-----------|-------------------------------|
| Id           | int       | Kullanıcı kimliği (PK)         |
| UserName     | string    | Kullanıcı adı                 |
| Password     | string    | Şifre                         |
| UserPicture  | string    | Profil resmi                  |
| SecurityCode | string    | Güvenlik kodu                 |
| CreatedDate  | datetime  | Hesap oluşturulma tarihi      |
| ModifiedDate | datetime  | Hesap güncellenme tarihi      |
| DeletedDate  | datetime  | Hesap silinme tarihi          |
| Status       | bool      | Hesap durumu (aktif/pasif)    |

#### UserDetails Tablosu
| Sütun Adı    | Veri Tipi | Açıklama                      |
|--------------|-----------|-------------------------------|
| Id           | int       | Detay kimliği (PK)            |
| FullName     | string    | Tam ad                       |
| Gender       | string    | Cinsiyet                     |
| BirthDate    | datetime  | Doğum tarihi                 |
| Height       | decimal   | Boy                          |
| Weight       | decimal   | Kilo                         |
| TotalCalorie | decimal   | Günlük kalori hedefi          |
| UserId       | int       | Kullanıcı kimliği (FK)        |
| CreatedDate  | datetime  | Oluşturulma tarihi            |
| ModifiedDate | datetime  | Güncellenme tarihi            |
| DeletedDate  | datetime  | Silinme tarihi                |
| Status       | bool      | Durum (aktif/pasif)           |

#### Foods Tablosu
| Sütun Adı     | Veri Tipi | Açıklama                      |
|---------------|-----------|-------------------------------|
| Id            | int       | Yiyecek kimliği (PK)           |
| FoodName      | string    | Yiyecek adı                   |
| Calorie       | decimal   | Kalori değeri                 |
| Protein       | decimal   | Protein miktarı               |
| Carbohydrate  | decimal   | Karbonhidrat miktarı          |
| Fat           | decimal   | Yağ miktarı                   |
| Measurement   | string    | Ölçü birimi                   |
| Picture       | string    | Yiyecek resmi                 |
| PortionType   | string    | Porsiyon tipi                 |
| CategoryId    | int       | Kategori kimliği (FK)         |
| CreatedDate   | datetime  | Oluşturulma tarihi            |
| ModifiedDate  | datetime  | Güncellenme tarihi            |
| DeletedDate   | datetime  | Silinme tarihi                |
| Status        | bool      | Durum (aktif/pasif)           |

#### Meals Tablosu
| Sütun Adı    | Veri Tipi | Açıklama                      |
|--------------|-----------|-------------------------------|
| Id           | int       | Öğün kimliği (PK)             |
| MealName     | string    | Öğün adı                      |
| CreatedDate  | datetime  | Oluşturulma tarihi            |
| ModifiedDate | datetime  | Güncellenme tarihi            |
| DeletedDate  | datetime  | Silinme tarihi                |
| Status       | bool      | Durum (aktif/pasif)           |

#### Categories Tablosu
| Sütun Adı    | Veri Tipi | Açıklama                      |
|--------------|-----------|-------------------------------|
| Id           | int       | Kategori kimliği (PK)         |
| CategoryName | string    | Kategori adı                  |
| CreatedDate  | datetime  | Oluşturulma tarihi            |
| ModifiedDate | datetime  | Güncellenme tarihi            |
| DeletedDate  | datetime  | Silinme tarihi                |
| Status       | bool      | Durum (aktif/pasif)           |

#### UserFoodMeals Tablosu
| Sütun Adı      | Veri Tipi | Açıklama                      |
|----------------|-----------|-------------------------------|
| Id             | int       | Kayıt kimliği (PK)            |
| TakenCalorie   | decimal   | Alınan kalori                 |
| MealEatDate    | datetime  | Öğün tarihi                   |
| Portion        | int       | Porsiyon sayısı               |
| UserId         | int       | Kullanıcı kimliği (FK)        |
| MealId         | int       | Öğün kimliği (FK)             |
| FoodId         | int       | Yiyecek kimliği (FK)          |
| CreatedDate    | datetime  | Oluşturulma tarihi            |
| ModifiedDate   | datetime  | Güncellenme tarihi            |
| DeletedDate    | datetime  | Silinme tarihi                |
| Status         | bool      | Durum (aktif/pasif)           |

## İlişkiler
- Bir **kullanıcı**, birden fazla öğünde yiyecek tüketebilir.
- **UserFoodMeals** tablosu, kullanıcıların tükettikleri yiyecekleri hangi öğünde ve ne kadar miktarda tükettiklerini kaydeder. Bu tablo, **Users**, **Meals** ve **Foods** tablolarına bağlanmıştır.
- **Foods** tablosundaki her yiyecek, bir **kategori**ye ait olabilir.

#### Veritabanı Bağlantı Ayarları:
- appsettings.json dosyasını açın ve bağlantı dizisini (ConnectionStrings) kendi SQL Server kurulumunuza göre güncelleyin:
- "ConnectionStrings": {
   "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=DeepFoodDiaryDB;Trusted_Connection=True;"
}
#### Projenin Localde Çalıştırılması İçin Gerekenler:
- Projedeki mevcut migration klasörünü sil
- UI katmanına sağ tıkla ve Set as Startup Project olarak ayarla
- Package Manager Console aç, default project bölümünde DAL katmanını seç.
- Package Manager Consola  add-migration initial  yazarak migration oluştur.
- Daha sonra update-database diyerek code first olara veritabanını oluştur.
