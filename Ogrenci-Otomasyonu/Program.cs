using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenciotomasyon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ogrenci = new string[5, 3];   //case1
            int sayac = 1, sayac2 = 1, sayac3 = 1;  //genel sayac
            string[,] dersler = new string[3, 2]; //case3

            int[,] notlar = new int[10, 3];
            int toplam1 = 0, toplam2 = 0, toplam3 = 0, toplam4 = 0, toplam5 = 0;   //toplam ders notları
            int saydir = 0, saydir2 = 0, saydir3 = 0, saydir4 = 0, saydir5 = 0;    //toplam ortalamanın paydası
            int payda1 = 0, payda2 = 0, payda3 = 0;  //ders ortalamasının paydası
            int toplamm1 = 0, toplamm2 = 0, toplamm3 = 0;     //bir dersin toplam notu

            int toplamm11 = 0, toplamm22 = 0, toplamm33 = 0, toplamm111 = 0, toplamm222 = 0, toplamm333 = 0, toplamm1111 = 0, toplamm2222 = 0, toplamm3333 = 0, toplamm11111 = 0, toplamm22222 = 0, toplamm33333 = 0;
            int payda11 = 0, payda22 = 0, payda33 = 0, payda111 = 0, payda222 = 0, payda333 = 0, payda1111 = 0, payda2222 = 0, payda3333 = 0, payda11111 = 0, payda22222 = 0, payda33333 = 0;


            bool donsunMu = true;
            while (donsunMu)
            {
                Console.WriteLine("#### Öğrenci Otomasyonu ####\n ");
                Console.WriteLine("1-Öğrenci Kaydet");
                Console.WriteLine("2-Öğrencileri Listele");
                Console.WriteLine("3-Ders Ekle");
                Console.WriteLine("4-Dersleri Listele");
                Console.WriteLine("5-Not Ekle");
                Console.WriteLine("6-Notları Listele");
                Console.WriteLine("\n ################################\n ");
                Console.WriteLine("7-Öğrenci Not Ortalaması");
                Console.WriteLine("8-Tüm Öğrencilerin Not Ortalaması");
                Console.WriteLine("\n ################################\n ");
                Console.WriteLine("0-Çıkış");
                Console.WriteLine(" ");
                tekrar:
                Console.Write("Lütfen Seçiminizi Yapınız : ");
                int yanit = int.Parse(Console.ReadLine());
                switch (yanit)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("#### ÖĞRENCİ GİRİŞİ ####\n");
                        Console.WriteLine("Girilecek Öğrenci Sayısı : 5");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("\n{0}.Öğrencinin bilgilerini giriniz;", sayac);
                            bidanogir:
                            Console.Write("Öğrenci No : ");
                            ogrenci[i, 0] = Console.ReadLine();
                            for (int h = 0; h < i; h++)
                            {
                                if (ogrenci[i, 0] == ogrenci[h, 0])
                                {
                                    Console.WriteLine("Bu öğrenci numarasına ait bir kayıt mevcuttur. Aynı numara ile birden fazla kayıt yapılamaz. Lütfen başka bir öğrenci numarası giriniz.");
                                    goto bidanogir;
                                    i--;
                                }
                            }
                            Console.Write("Öğrenci Adı : ");
                            ogrenci[i, 1] = Console.ReadLine();
                            Console.Write("Öğrenci Soyadı : ");
                            ogrenci[i, 2] = Console.ReadLine();
                            sayac++;
                        }
                        Console.Write("\nVeriler eklendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("#### ÖĞRENCİ LİSTESİ ####\n");
                        string[,] bilgiler = new string[1, 3];
                        bilgiler[0, 0] = "Numara";
                        bilgiler[0, 1] = "Ad";
                        bilgiler[0, 2] = "Soyad";
                        for (int h = 0; h < 1; h++)
                        {
                            for (int g = 0; g < 3; g++)
                            {
                                Console.Write("{0,-10}", bilgiler[h, g]);
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                Console.Write("{0,-10}", ogrenci[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nVeriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("#### DERS GİRİŞİ ####\n");
                        Console.WriteLine("Girilecek Ders Sayısı : 3\n");
                        for (int d = 0; d < 3; d++)
                        {
                            Console.WriteLine("\n{0}.Dersin bilgilerini giriniz;", sayac2);
                            bidakodgir:
                            Console.Write("Ders Kodu : ");
                            dersler[d, 0] = Console.ReadLine();
                            for (int h = 0; h < d; h++)
                            {
                                if (dersler[d, 0] == dersler[h, 0])
                                {
                                    Console.WriteLine("Bu ders koduna ait bir kayıt mevcuttur. Aynı numara ile birden fazla kayıt yapılamaz. Lütfen başka bir ders kodu giriniz.");
                                    goto bidakodgir;
                                   
                                }
                            }
                            Console.Write("Ders Adı : ");
                            dersler[d, 1] = Console.ReadLine();
                            sayac2++;

                        }
                        Console.Write("\nVeriler eklendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("#### DERS LİSTESİ ####\n");

                        string[,] bilgiler2 = new string[1, 2];
                        bilgiler2[0, 0] = "Ders Kodu";
                        bilgiler2[0, 1] = "Ders Adı";
                        for (int h = 0; h < 1; h++)
                        {
                            for (int g = 0; g < 2; g++)
                            {
                                Console.Write("{0,-15}", bilgiler2[h, g]);
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.Write("{0,-15}", dersler[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nVeriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("#### NOT GİRİŞİ ####");
                        Console.WriteLine("Girilecek Not Sayısı : 10\n");
                        for (int c = 0; c < 10; c++)
                        {
                            for (int v = 0; v < 3;)
                            {
                                Console.WriteLine("{0}.Notun bilgilerini giriniz;", sayac3);
                                tekrarogrencino:
                                Console.Write("Öğrenci No : ");
                                notlar[c, v] = int.Parse(Console.ReadLine());
                                if (notlar[c, v] == Convert.ToInt32(ogrenci[0, 0]) || notlar[c, v] == Convert.ToInt32(ogrenci[1, 0]) || notlar[c, v] == Convert.ToInt32(ogrenci[2, 0]) || notlar[c, v] == Convert.ToInt32(ogrenci[3, 0]) || notlar[c, v] == Convert.ToInt32(ogrenci[4, 0]))
                                {
                                    goto devamet2;
                                }
                                else
                                {
                                    Console.WriteLine("Bu öğrenci koduna ait bir kayıt bulunamadı. Lütfen kayıtlı öğrenci kodlarını kullanınız.");
                                    goto tekrarogrencino;
                                }
                                devamet2:
                                v++;
                                tekrarderskodu:
                                Console.Write("Ders Kodu : ");
                                notlar[c, v] = int.Parse(Console.ReadLine());
                                if (notlar[c, v] == Convert.ToInt32(dersler[0, 0]) || notlar[c, v] == Convert.ToInt32(dersler[1, 0]) || notlar[c, v] == Convert.ToInt32(dersler[2, 0]))
                                {
                                    goto devamet;
                                }
                                else
                                {
                                    Console.WriteLine("Bu ders koduna ait bir kayıt bulunamadı. Lütfen kayıtlı ders kodlarını kullanınız.");
                                    goto tekrarderskodu;
                                }
                                devamet:
                                v++;
                                sifiryuz:
                                Console.Write("Not : ");
                                notlar[c, v] = int.Parse(Console.ReadLine());
                                for (int z = 0; z < 10; z++)
                                {
                                    if (notlar[c, 2] > 100 || notlar[c, 2] < 0)
                                    {
                                        Console.WriteLine("0 ile 100 arasında bir not giriniz.");
                                        goto sifiryuz;
                                    }
                                }
                                v++;
                                sayac3++;
                            }
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 2; j++)
                            {
                                if (notlar[i, 0] == Convert.ToInt32(ogrenci[0, 0]))
                                {
                                    if (notlar[i, j] == Convert.ToInt32(dersler[0, 0]))
                                    {
                                        j = j + 1;
                                        toplamm1 += notlar[i, j];
                                        payda1++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[1, 0]))
                                    {
                                        j = j + 1;
                                        toplamm2 += notlar[i, j];
                                        payda2++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[2, 0]))
                                    {
                                        j = j + 1;
                                        toplamm3 += notlar[i, j];
                                        payda3++;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 2; j++)
                            {
                                if (notlar[i, 0] == Convert.ToInt32(ogrenci[1, 0]))
                                {
                                    if (notlar[i, j] == Convert.ToInt32(dersler[0, 0]))
                                    {
                                        j = j + 1;
                                        toplamm11 += notlar[i, j];
                                        payda11++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[1, 0]))
                                    {
                                        j = j + 1;
                                        toplamm22 += notlar[i, j];
                                        payda22++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[2, 0]))
                                    {
                                        j = j + 1;
                                        toplamm33 += notlar[i, j];
                                        payda33++;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 2; j++)
                            {
                                if (notlar[i, 0] == Convert.ToInt32(ogrenci[2, 0]))
                                {
                                    if (notlar[i, j] == Convert.ToInt32(dersler[0, 0]))
                                    {
                                        j = j + 1;
                                        toplamm111 += notlar[i, j];
                                        payda111++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[1, 0]))
                                    {
                                        j = j + 1;
                                        toplamm222 += notlar[i, j];
                                        payda222++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[2, 0]))
                                    {
                                        j = j + 1;
                                        toplamm333 += notlar[i, j];
                                        payda333++;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 2; j++)
                            {
                                if (notlar[i, 0] == Convert.ToInt32(ogrenci[3, 0]))
                                {
                                    if (notlar[i, j] == Convert.ToInt32(dersler[0, 0]))
                                    {
                                        j = j + 1;
                                        toplamm1111 += notlar[i, j];
                                        payda1111++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[1, 0]))
                                    {
                                        j = j + 1;
                                        toplamm2222 += notlar[i, j];
                                        payda2222++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[2, 0]))
                                    {
                                        j = j + 1;
                                        toplamm3333 += notlar[i, j];
                                        payda3333++;
                                    }
                                }
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 1; j < 2; j++)
                            {
                                if (notlar[i, 0] == Convert.ToInt32(ogrenci[4, 0]))
                                {
                                    if (notlar[i, j] == Convert.ToInt32(dersler[0, 0]))
                                    {
                                        j = j + 1;
                                        toplamm11111 += notlar[i, j];
                                        payda11111++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[1, 0]))
                                    {
                                        j = j + 1;
                                        toplamm22222 += notlar[i, j];
                                        payda22222++;
                                    }
                                    if (notlar[i, j] == Convert.ToInt32(dersler[2, 0]))
                                    {
                                        j = j + 1;
                                        toplamm33333 += notlar[i, j];
                                        payda33333++;
                                    }
                                }
                            }
                        }

                        for (int c = 0; c < 10; c++)
                        {
                            for (int v = 0; v < 3; v++)
                            {

                                if (notlar[c, v] == Convert.ToInt32(ogrenci[0, 0]))
                                {
                                    v = v + 2;
                                    toplam1 += notlar[c, v];
                                    saydir++;

                                }
                                if (notlar[c, v] == Convert.ToInt32(ogrenci[1, 0]))
                                {
                                    v = v + 2;
                                    toplam2 += notlar[c, v];
                                    saydir2++;
                                }
                                if (notlar[c, v] == Convert.ToInt32(ogrenci[2, 0]))
                                {
                                    v = v + 2;
                                    toplam3 += notlar[c, v];
                                    saydir3++;
                                }
                                if (notlar[c, v] == Convert.ToInt32(ogrenci[3, 0]))
                                {
                                    v = v + 2;
                                    toplam4 += notlar[c, v];
                                    saydir4++;
                                }
                                if (notlar[c, v] == Convert.ToInt32(ogrenci[4, 0]))
                                {
                                    v = v + 2;
                                    toplam5 += notlar[c, v];
                                    saydir5++;
                                }
                            }
                        }
                        Console.Write("\nVeriler eklendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("#### NOT LİSTESİ ####");
                        Console.WriteLine("");
                        string[,] genel = new string[10, 4];

                        string[,] bilgiler3 = new string[1, 4];
                        bilgiler3[0, 0] = "Ad";
                        bilgiler3[0, 1] = "Soyad";
                        bilgiler3[0, 2] = "Ders";
                        bilgiler3[0, 3] = "Not";
                        for (int h = 0; h < 1; h++)
                        {
                            for (int g = 0; g < 4; g++)
                            {
                                Console.Write("{0,-15}", bilgiler3[h, g]);
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[0, 0]))
                            {
                                genel[i, 0] = ogrenci[0, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[0, 0]))
                            {
                                genel[i, 1] = ogrenci[0, 2];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[1, 0]))
                            {
                                genel[i, 0] = ogrenci[1, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[1, 0]))
                            {
                                genel[i, 1] = ogrenci[1, 2];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[2, 0]))
                            {
                                genel[i, 0] = ogrenci[2, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[2, 0]))
                            {
                                genel[i, 1] = ogrenci[2, 2];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[3, 0]))
                            {
                                genel[i, 0] = ogrenci[3, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[3, 0]))
                            {
                                genel[i, 1] = ogrenci[3, 2];
                            }
                        }

                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[4, 0]))
                            {
                                genel[i, 0] = ogrenci[4, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 0] == Convert.ToInt32(ogrenci[4, 0]))
                            {
                                genel[i, 1] = ogrenci[4, 2];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 1] == Convert.ToInt32(dersler[0, 0]))
                            {
                                genel[i, 2] = dersler[0, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 1] == Convert.ToInt32(dersler[1, 0]))
                            {
                                genel[i, 2] = dersler[1, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            if (notlar[i, 1] == Convert.ToInt32(dersler[2, 0]))
                            {
                                genel[i, 2] = dersler[2, 1];
                            }
                        }
                        for (int i = 0; i < 10; i++)
                        {
                            genel[i, 3] = notlar[i, 2].ToString();

                        }
                        for (int i = 0; i < 10; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.Write("{0,-15}", genel[i, j]);
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nVeriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("#### ÖĞRENCİ NOT ORTALAMASI ####");
                        Console.Write("\nOrtalaması bulunacak öğrenci numarasını giriniz : ");
                        int numaraa = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if (numaraa == Convert.ToInt32(ogrenci[0, 0]))
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                if (payda1 == 0)
                                {
                                    goto atla;
                                }
                                if (notlar[i, 1] == Convert.ToInt32(dersler[0, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[0, 1], (toplamm1 / payda1));
                                    break;
                                }
                            }
                            atla:
                            for (int j = 0; j < 10; j++)
                            {
                                if (payda2 == 0)
                                {
                                    goto atla2;
                                }
                                if (notlar[j, 1] == Convert.ToInt32(dersler[1, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[1, 1], (toplamm2 / payda2));
                                    break;
                                }
                            }
                            atla2:
                            for (int a = 0; a < 10; a++)
                            {
                                if (payda3 == 0)
                                {
                                    goto atla3;
                                }
                                if (notlar[a, 1] == Convert.ToInt32(dersler[2, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[2, 1], (toplamm3 / payda3));
                                    break;
                                }
                            }
                        }
                        atla3:
                        if (numaraa == Convert.ToInt32(ogrenci[1, 0]))
                        {
                            for (int p = 0; p < 10; p++)
                            {
                                if (payda11 == 0)
                                {
                                    goto atla4;
                                }
                                if (notlar[p, 1] == Convert.ToInt32(dersler[0, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[0, 1], (toplamm11 / payda11));
                                    break;
                                }
                            }
                            atla4:
                            for (int b = 0; b < 10; b++)
                            {
                                if (payda22 == 0)
                                {
                                    goto atla5;
                                }
                                if (notlar[b, 1] == Convert.ToInt32(dersler[1, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[1, 1], (toplamm22 / payda22));
                                    break;
                                }
                            }
                            atla5:
                            for (int c = 0; c < 10; c++)
                            {
                                if (payda33 == 0)
                                {
                                    goto atla6;
                                }
                                if (notlar[c, 1] == Convert.ToInt32(dersler[2, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[2, 1], (toplamm33 / payda33));
                                    break;
                                }
                            }
                        }
                        atla6:

                        if (numaraa == Convert.ToInt32(ogrenci[2, 0]))
                        {
                            for (int o = 0; o < 10; o++)
                            {
                                if (payda111 == 0)
                                {
                                    goto atla7;
                                }
                                if (notlar[o, 1] == Convert.ToInt32(dersler[0, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[0, 1], (toplamm111 / payda111));
                                    break;
                                }
                            }
                            atla7:
                            for (int d = 0; d < 10; d++)
                            {
                                if (payda222 == 0)
                                {
                                    goto atla8;
                                }
                                if (notlar[d, 1] == Convert.ToInt32(dersler[1, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[1, 1], (toplamm222 / payda222));
                                    break;
                                }
                            }
                            atla8:
                            for (int f = 0; f < 10; f++)
                            {
                                if (payda333 == 0)
                                {
                                    goto atla9;
                                }
                                if (notlar[f, 1] == Convert.ToInt32(dersler[2, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[2, 1], (toplamm333 / payda333));
                                    break;
                                }
                            }
                        }
                        atla9:
                        if (numaraa == Convert.ToInt32(ogrenci[3, 0]))
                        {
                            for (int u = 0; u < 10; u++)
                            {
                                if (payda1111 == 0)
                                {
                                    goto atla10;
                                }
                                if (notlar[u, 1] == Convert.ToInt32(dersler[0, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[0, 1], (toplamm1111 / payda1111));
                                    break;
                                }
                            }
                            atla10:
                            for (int g = 0; g < 10; g++)
                            {
                                if (payda2222 == 0)
                                {
                                    goto atla11;
                                }
                                if (notlar[g, 1] == Convert.ToInt32(dersler[1, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[1, 1], (toplamm2222 / payda2222));
                                    break;
                                }
                            }
                            atla11:
                            for (int h = 0; h < 10; h++)
                            {
                                if (payda3333 == 0)
                                {
                                    goto atla12;
                                }
                                if (notlar[h, 1] == Convert.ToInt32(dersler[2, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[2, 1], (toplamm3333 / payda3333));
                                    break;
                                }
                            }
                        }
                        atla12:
                        if (numaraa == Convert.ToInt32(ogrenci[4, 0]))
                        {
                            for (int e = 0; e < 10; e++)
                            {
                                if (payda11111 == 0)
                                {
                                    goto atla13;
                                }
                                if (notlar[e, 1] == Convert.ToInt32(dersler[0, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[0, 1], (toplamm11111 / payda11111));
                                    break;
                                }
                            }
                            atla13:
                            for (int x = 0; x < 10; x++)
                            {
                                if (payda22222 == 0)
                                {
                                    goto atla14;
                                }
                                if (notlar[x, 1] == Convert.ToInt32(dersler[1, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[1, 1], (toplamm22222 / payda22222));
                                    break;
                                }
                            }
                            atla14:
                            for (int y = 0; y < 10; y++)
                            {
                                if (payda33333 == 0)
                                {
                                    goto atla15;
                                }
                                if (notlar[y, 1] == Convert.ToInt32(dersler[2, 0]))
                                {
                                    Console.WriteLine("Girilen öğrenci için {0} dersine ait ortalama not : {1}", dersler[2, 1], (toplamm33333 / payda33333));
                                    break;
                                }
                            }
                        }
                        atla15:
                        Console.Write("\n\nHiçbir not girmediğiniz derslerin ortalaması olmayacağı için yukarıda GÖZÜKMEYECEKTİR!\n");
                        Console.Write("\nVeriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("#### ÖĞRENCİ NOT ORTALAMASI ####");
                        Console.WriteLine("");
                        if (saydir == 0)
                            goto atlattir;
                        Console.WriteLine("{0} {1} adlı öğrencinin tüm dersler için ortalama notu : {2}", ogrenci[0, 1], ogrenci[0, 2], (toplam1 / saydir));
                        atlattir:
                        if (saydir2 == 0)
                            goto atlattir2;
                        Console.WriteLine("{0} {1} adlı öğrencinin tüm dersler için ortalama notu : {2}", ogrenci[1, 1], ogrenci[1, 2], (toplam2 / saydir2));
                        atlattir2:
                        if (saydir3 == 0)
                            goto atlattir3;
                        Console.WriteLine("{0} {1} adlı öğrencinin tüm dersler için ortalama notu : {2}", ogrenci[2, 1], ogrenci[2, 2], (toplam3 / saydir3));
                        atlattir3:
                        if (saydir4 == 0)
                            goto atlattir4;
                        Console.WriteLine("{0} {1} adlı öğrencinin tüm dersler için ortalama notu : {2}", ogrenci[3, 1], ogrenci[3, 2], (toplam4 / saydir4));
                        atlattir4:
                        if (saydir5 == 0)
                            goto atlattir5;
                        Console.WriteLine("{0} {1} adlı öğrencinin tüm dersler için ortalama notu : {2}", ogrenci[4, 1], ogrenci[4, 2], (toplam5 / saydir5));
                        atlattir5:
                        Console.Write("\n\nHiçbir not girmediğiniz derslerin ortalaması olmayacağı için yukarıda GÖZÜKMEYECEKTİR!\n");
                        Console.Write("\nVeriler listelendi. Üst dizine çıkmak için ENTER tuşuna basınız.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        donsunMu = false;
                        return;
                    default:
                        Console.WriteLine("Lütfen geçerli bir numara giriniz.");
                        goto tekrar;
                }
            }
            Console.ReadLine();
        }
    }
}
