# Süper Market Otomasyonu
* ///////////////////////////////////////////////////////
* *Bu projede kullanılan programlama dili ve programlar*
* Programlama Dili : PYTHON
* Veritabanı : SQLite
* Derleme Ortamı : VS Code*
* ///////////////////////////////////////////////////////

Merhaba!
SüperMarket projemi Python öğrenmeye başladığım zamanlarda yaptım. Bu projede Sqlite veritabanı kullanarak bilgileri tuttum. Basit düzeyde Sqlite bilgisine sahip olanlar rahatça veritabanı kodlarını anlayabilir.

**SüperMarket Proje Özellikleri:**
* Ürün Ekle
* Ürün Sil
* Stok Sorgula (Ürün Adına Göre)
* Stok Sorgula (Marka Adına Göre)
* SuperMarket Toplam Stoğu Sorgula
* Son Kullanma Tarihi Geçenleri Raflardan Kaldır
* Satış Yap
* İade Al
* Günlük Toplam Müşteri Sayısı
* Günlük Toplam Alınan İade Sayısı
* Günlük Ciro Hesapla
* Kasayı Kapat

-------------------------------------------------

**1-Ürün Ekle:**
Bu seçimde kullanıcıdan, Ürün Adı, Marka, Fiyat, Son Kullanma Tarihi, Ürün Çeşidi, Stok Miktarı bilgilerini girilmesi isteniyor. Bu işlemler sonucunda girilen ürün ve miktarı veritabanına ekleniyor.

**2-Ürün Sil:**
Bu seçimde kullanıcıdan silmek istediği ürünün adını istiyor. Girilen ürün adındaki bütün stokları siliyor.

**3-Stok Sorgula (Ürün Adına Göre):**
Bu seçimde kullanıcıdan stoğunu sorgulamak istediği ürünün adını istiyor. Kullanıcı adını girdiği ürünün stok miktarını görebiliyor.

**4-Stok Sorgula (Marka Adına Göre):**
Bu seçimde kullanıcıdan sorgulamak istediği markanın adını istiyor. Bu markaya ait olan tüm ürünlerin(çerez,içecek,yiyecek vs) toplam stoğunu öğrenilebilir.

**5-SuperMarket Toplam Stoğu Sorgula:**
Bu seçim sonucunda Süper Market stoğundaki bütün ürünlerin toplam stoğu öğrenilebilir.

**6-Son Kullanma Tarihi Geçenleri Raflardan Kaldır:**
Bu seçimde kullanıcıdan bir son kullanma tarihi girmesi isteniyor. Kullanıcının girdiği son kullanma tarihinden önceki bütün ürünler raflardan kalkar yani silinir. Bu sayede son kullanma tarihi geçmiş bir ürün satışı yapılmamış olur.

**7-Satış Yap:**
Bu seçimde ekrana bilgilendirme yazısı çıkıyor. ” iptal etmek için ‘i’ basın. fiş kesmek için ‘f’ basın. ” şeklinde. Satış sırasında işlem iptal edilebiliyor. Bu durumda stoktan ürün eksilmesi olmaz ve günlük ciroda değişim olmaz. fiş kesersek satış işlemi tamamlanmış olur. Satış yaparken ürün adını girmemiz gerekiyor. Örneğin, Kola yazdık, ekrana “Ürün Sepetinize Eklendi!” bilgisini veriyor. ‘f’ basarak fiş kesersek sepetimizdeki toplam ürün tutarını ekrana yazıyor. Örneğin “Toplam Tutar : 5 TL” şeklinde.

**8-İade Al:**
Bu seçimde iade olarak gelen ürünün adını yazmak yeterli olacaktır. İade alındığı zaman günlük ciro’dan bu miktar düşülür ve iade edilen ürün stoğa eklenir.

**9-Günlük Toplam Müşteri Sayısı:**
Bu seçimde gün içinde alışveriş yapan müşterilerin sayısı görülebilir. Örneğin, “Bugün toplam 10 müşteriye hizmet verdiniz.”

**10-Günlük Toplam Alınan İade Sayısı:**
Bu seçimde gün içinde alınan iadelerin sayısı görülebilir. 
Örneğin, “Bugün Toplam 1 İade Aldınız.”

**11-Günlük Ciro Hesapla:**
Bu seçimde gün içinde satışı yapılan ürünlerden kazanılan toplam ciro görülebilir. Eğer satışınız, iadenizden fazla ise Kârdasınız! şeklinde bilgilendirme alırsınız. Durum tam tersi ise Zarardasınız! şeklinde bilgilendirme alırsınız. Örneğin,
Kârdasınız!
Günlük Toplam Cironuz : 98.0 TL

**12-Kasayı Kapat:**
Bu seçimde kasa kapatılır ve bu gün sonu olduğu anlamına gelir. Bu işlem sonucunda gün boyunca yapılan satış, iade ve ciro başka bir veritabanına kaydedilerek, Günlük olarak veri incelenmesine olanak tanınmış olur. 1 Ay sonunda günlük verilerin tutulduğu veriye girerek, ay boyunca nasıl bir grafik izlenildiği gözlemlenebilir.

## Program içi görseller:

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/1.jpg)

-------------------------------------------------

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/2.jpg)

-------------------------------------------------

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/3.jpg)

-------------------------------------------------

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/4.jpg)

-------------------------------------------------

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/5.jpg)

-------------------------------------------------

## Veritabanı görüntüleri:

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/s1.jpg)
(Ürünlerin bulunduğu tablo)

-------------------------------------------------

![alt text](https://raw.githubusercontent.com/serdarsari/Projelerim/master/S%C3%BCper%20Market%20Otomasyonu/images/s2.jpg)
Günlük verilerin tutulduğu tablo.(Her satır 1 günü ifade ediyor) Örneğin bu tabloda 6 gün kayıtlı

