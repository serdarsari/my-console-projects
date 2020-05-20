import sqlite3



class Urun():
    def __init__(self,uAdi,marka,fiyat,skt,uCesidi,stok):
        self.uAdi=uAdi
        self.marka=marka
        self.fiyat=fiyat
        self.skt=skt
        self.uCesidi=uCesidi
        self.stok=stok
    
    def __str__(self):      #print() fonksiyonunun stoğu geri döndürmesini sağlıyoruz.
        return self.stok
    
class SuperMarket():
    def __init__(self):
        self.VeritabaninaBaglan()

        #Aslında bunlar değişkenler. Kullanmadan önce 0 değeri atamamız zorunlu olduğu için burada böyle tanımladım bunları...
        self.ilkGiris=True   #init fonksiyonu ilk çalışan fonksiyon olduğu için buraya yazdım. programın başında çalışmasını istiyorum.
        self.gunlukToplamMusteri=0  #init fonksiyonu ilk çalışan fonksiyon olduğu için buraya yazdım. programın başında çalışmasını istiyorum.
        self.toplamfiyat=0   #init fonksiyonu ilk çalışan fonksiyon olduğu için buraya yazdım. programın başında çalışmasını istiyorum.
        self.toplamCiro=0   #init fonksiyonu ilk çalışan fonksiyon olduğu için buraya yazdım. programın başında çalışmasını istiyorum.
        self.gunlukToplamIade=0


    def VeritabaninaBaglan(self):
        self.baglanti = sqlite3.connect("veriler.db")
        self.cursor=self.baglanti.cursor()

        sorgu = "CREATE TABLE IF NOT EXISTS veriler(UrunAdi TEXT,Marka TEXT,Fiyat REAL,SKT TEXT,UrunCesidi TEXT,Stok INT)"

        self.cursor.execute(sorgu)
        self.baglanti.commit()
    
    def VeritabaniBaglantisiniKes(self):
        self.baglanti.close()

    def UrunEkle(self,urunNesnesi):
        sorgu = "INSERT INTO veriler VALUES(?,?,?,?,?,?)"
        self.cursor.execute(sorgu,(urunNesnesi.uAdi,urunNesnesi.marka,urunNesnesi.fiyat,urunNesnesi.skt,urunNesnesi.uCesidi,urunNesnesi.stok))
        self.baglanti.commit()
    
    def UrunSil(self,isim):
        #Aşağıdaki sorguyu, sistemde silmek istediği ürün varmı diye bakmak için yaptım.
        #Eğer bu sorguyu DELETE 'in altında yapsaydım,sorgu bulup sildiği için sorgu2 sistemde bulamadığı için Her seferinde if'e girecekti.
        #Bunu üstte yazarsak önce veritabanını sorgulayacak if veya else girip alttaki sorgu2'den devam edecek.
        #DELETE işlemi, veritabanında bulunsada bulunmasada hata vermeden devam eder. Varsa siler yoksa hatasız devam eder.
        sorgu2="SELECT * FROM veriler WHERE UrunAdi = ?"
        self.cursor.execute(sorgu2,(isim,))
        silinecekUrunler=self.cursor.fetchall()

        if (len(silinecekUrunler)==0):
            print("Böyle bir ürün bulunmuyor.")
        else:
            print("Ürün Silindi!")
        
        #################################################
        sorgu = "DELETE FROM veriler WHERE UrunAdi = ?"
        self.cursor.execute(sorgu,(isim,))
        self.baglanti.commit()
    
    def UrunAdinaGoreStokSorgula(self,isim):
        sorgu = "SELECT * FROM veriler WHERE UrunAdi = ?"
        self.cursor.execute(sorgu,(isim,))
        urunler=self.cursor.fetchall()    #veritabanındaki bu ürün adındaki verileri çekiyorum.
                                          

        if (len(urunler)==0):
            print("Stokta böyle bir ürün bulunmuyor.")
        else:
            toplamurun=0
            for i in urunler:         #Aynı ürünü sonradan birdaha eklemiş olabilirim. Bu urunler listesinin içine atanır.
                                      #Bu yüzden urunler listesini for ile geziyorum. hepsinin 5.indeksindeki stok verisine erişip,
                                      #o değeri toplamurun değişkenine atayarak topluyorum.
                toplamurun +=i[5]
            print(toplamurun)         #en sonda toplamurun'ü yazdırıyorum.
        
    def MarkayaGoreStokSorgula(self,marka):
        sorgu = "SELECT * FROM veriler WHERE Marka = ?"
        self.cursor.execute(sorgu,(marka,))
        markaurunleri = self.cursor.fetchall()

        if(len(markaurunleri)==0):
            print("Stokta böyle bir marka ürünü bulunmuyor.")
        else:
            toplammarkaurunu=0
            for i in markaurunleri:
                toplammarkaurunu += i[5]
            print("{} Markasına ait toplamda {} ürün mevcut".format(marka,toplammarkaurunu))
    
    def SuperMarketToplamUrunStoguSorgula(self):
        sorgu = "SELECT * FROM veriler"
        self.cursor.execute(sorgu)
        toplamstok=self.cursor.fetchall()

        if (len(toplamstok)==0):
            print("Stokta ürün bulunmuyor.")
        else:
            toplamurunstogu=0
            for i in toplamstok:
                toplamurunstogu +=i[5]
            
            print("Bulunan tüm ürünlerin toplam stoğu {}'dir".format(toplamurunstogu))
    
    def TarihiGecenleriSil(self,isim):   #bu fonksiyonu sadece SonKullanmaTarihiGecenleriSil() fonksiyonunda kullanmak için oluşturdum.
        sorgu = "DELETE FROM veriler WHERE UrunAdi = ?"
        self.cursor.execute(sorgu,(isim,))
        self.baglanti.commit()

    def SonKullanmaTarihiGecenleriSil(self,tarih):
        sorgu = "SELECT * FROM veriler"
        self.cursor.execute(sorgu)
        butunurunler = self.cursor.fetchall()

        if (len(butunurunler)==0):
            print("Stokta hiçbir ürün bulunmuyor.")
        else:
            for i in butunurunler:
                sktlistesi = i[3].split(".")    #i.demetin 3.elemanı skt idi. Bunu .'lardan bölüyorum.
                tarihlistesi = tarih.split(".")   #dışarıdan girdiğim tarihide aynı şekilde bölüyorum.

                if (tarihlistesi[2]>sktlistesi[2]):    #Önce Yıla bakıyorum. Eğer girdiğim yıldan düşükse direk girip sil.
                    self.TarihiGecenleriSil(i[0])
                elif (tarihlistesi[2]==sktlistesi[2] and tarihlistesi[1]>sktlistesi[1]):  #Eğer yıllar eşitse aya bakıyorum. Girdiğim ay'dan düşükse girip sil
                    self.TarihiGecenleriSil(i[0])
                elif(tarihlistesi[2]==sktlistesi[2] and tarihlistesi[1]==sktlistesi[1] and tarihlistesi[0]>sktlistesi[0]):  #Eğer yıllar ve aylar eşitse güne bakıyorum. Girilen günden küçükse girip sil
                    self.TarihiGecenleriSil(i[0])
    
    
    def SatisYap(self,isim):
        self.satisisim=isim
        sorgu = "SELECT * FROM veriler WHERE UrunAdi = ?"
        self.cursor.execute(sorgu,(isim,))
        urun=self.cursor.fetchall()

        

        if(len(urun)==0):
            print("Bu ürün bulunmuyor.")
        else:
            if (self.ilkGiris):    #her seferinde self.urunstok=urun[0][5] yaparsa aynı üründen birden çok satın alınca 1 tane düşürüyor. Bu yüzden buna sadece en başta 1 defa girmesi için if'e soktum.
                self.urunstok=urun[0][5]     #
            self.urunstok -= 1
            
            self.toplamfiyat +=urun[0][2]

            print("Ürün Sepetinize Eklendi!")
            self.ilkGiris=False    #Burda False yapıyorum ki birdaha girmesin. Taa ki fiş kesilene kadar. Her fiş kesiminde ürün stoğunu güncelleyecek.
                                   #Tekrardan satis yapılacağı zaman FisKes metodunda True yaptığımız için tekrar satış yapacağımızda yine ilk defasında 1 defa giriyor if'e.
    
    def FisKes(self):
        sorgu="UPDATE veriler SET Stok = ? WHERE UrunAdi = ?"     #Burda güncellememin sebebi, Fis kesmeden ürünün stoktan düşmemesi için.
        self.cursor.execute(sorgu,(self.urunstok,self.satisisim))   #Fiş kesildikten sonra ürün stoktan düşüyor.
        self.baglanti.commit()
        print("Toplam Tutar : {} TL".format(self.toplamfiyat))
        self.gunlukToplamMusteri +=1
        self.toplamCiro+=self.toplamfiyat

        self.ilkGiris=True        #Buraya kadar burada fiş kesildikten sonra tekrar True yapıyorum.
        self.toplamfiyat=0
        
    def GunlukToplamMusteriSayisi(self):
        print("Bugün toplam {} müşteriye hizmet verdiniz.".format(self.gunlukToplamMusteri))

    def GunlukCiroHesapla(self):
        if (self.toplamCiro>0):
            print("-----------")
            print("Kârdasınız!")
        elif(self.toplamCiro<0):
            print("-------------")
            print("Zarardasınız!")
        print("Günlük Toplam Cironuz : {} TL".format(self.toplamCiro))

    def IadeAl(self,isim):
        sorgu="SELECT * FROM veriler WHERE UrunAdi = ?"
        self.cursor.execute(sorgu,(isim,))
        urunler = self.cursor.fetchall()

        stok = urunler[0][5]

        stok +=1
        self.toplamCiro-=urunler[0][2]
        sorgu2="UPDATE veriler SET Stok = ? WHERE UrunAdi = ?"
        self.cursor.execute(sorgu2,(stok,isim))
        self.baglanti.commit()

        print("İade Alındı! Teşekkürler.")
        self.gunlukToplamIade+=1



    def GunlukAlinanIadeSayisi(self):
        print("Bugün Toplam {} İade Aldınız.".format(self.gunlukToplamIade))


    def KasayiKapat(self):
        
        baglanti2=sqlite3.connect("gunlukVeriler.db")
        cursor2=baglanti2.cursor()
        sorgu ="CREATE TABLE IF NOT EXISTS gunlukVeriler(GunlukToplamMusteri INT,GunlukToplamCiro INT,GunlukToplamIade INT)"
        cursor2.execute(sorgu)
        baglanti2.commit()

        sorgu2="INSERT INTO gunlukVeriler VALUES(?,?,?)"
        cursor2.execute(sorgu2,(self.gunlukToplamMusteri,self.toplamCiro,self.gunlukToplamIade))
        baglanti2.commit()




        self.gunlukToplamMusteri=0
        self.toplamCiro=0
        self.gunlukToplamIade=0





        
