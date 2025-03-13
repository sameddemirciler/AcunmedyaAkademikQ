// See https://aka.ms/new-console-template for more information
using Loop___Condition_Assignment___PRS.Classes;

Insan i = new Insan();
Araba a = new Araba();





Console.WriteLine("Doğduğunuz yılı giriniz :");
int dogumYili = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sizin yaşınız :" + i.yasHesapla(dogumYili));

if (i.yasHesapla(dogumYili) < 0 || i.yasHesapla(dogumYili) > 99)
{
    Console.WriteLine("Ya hiç doğmadınız ya da çoktan öldünüz!!");
}

else if(i.yasHesapla(dogumYili)>=0 && i.yasHesapla(dogumYili) < 18)
{
    Console.WriteLine("Küçüksünüz");
}
else if(i.yasHesapla(dogumYili)>= 18 && i.yasHesapla(dogumYili) <35)
{
    Console.WriteLine("Gençsiniz");
}
else if (i.yasHesapla(dogumYili) >= 35 && i.yasHesapla(dogumYili) < 55)
{
    Console.WriteLine("Yetişkinsiniz");
}
else if (i.yasHesapla(dogumYili) >= 55 && i.yasHesapla(dogumYili) < 75)
{
    Console.WriteLine("Yaşlısınız");
}
else if (i.yasHesapla(dogumYili) >= 75 && i.yasHesapla(dogumYili) < 95)
{
    Console.WriteLine("Çok Yaşlısınız");
}
else
{
    Console.WriteLine("Çok yaşlısınız");
}


Console.WriteLine("Arabanızın üretim yılını giriniz :");
int üretimYili = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Arabanızın yaşı :" + a.arabaYas(üretimYili));

if (a.arabaYas(üretimYili) < 0 || a.arabaYas(üretimYili) > 30)
{
    Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir!!");
}
else if (a.arabaYas(üretimYili) > 0 && a.arabaYas(üretimYili) < 10)
{
    Console.WriteLine("Arabanız yeni");
}
else if (a.arabaYas(üretimYili) > 10 && a.arabaYas(üretimYili) < 20)
{
    Console.WriteLine("Servise götürmeniz gerekebilir");
}
else
{
    Console.WriteLine("Arabanız hurdaya çıkabilir");
}

//switch-case, çoklu koşul (durum) kontrollerinde kullanılan bir karar yapısıdır.
//Genellikle bir değişkenin değerine göre farklı işlemler yapmak istediğimizde kullanılır.
// if-else bloklarının daha okunabilir ve düzenli bir alternatifi gibidir.

//switch-case ile yapılmış hali :


Console.WriteLine("Arabanızın üretim yılını giriniz :");
üretimYili = Convert.ToInt32(Console.ReadLine());
int yas = a.arabaYas(üretimYili);

Console.WriteLine("Arabanızın yaşı : " + yas);

switch (yas)
{
    case int n when (n < 0 || n > 30):
        Console.WriteLine("Ya hiç üretilmedi ya da trafikten men edilmiştir!!");
        break;

    case int n when (n > 0 && n < 10):
        Console.WriteLine("Arabanız yeni");
        break;

    case int n when (n >= 10 && n < 20):  
        Console.WriteLine("Servise götürmeniz gerekebilir");
        break;

    case int n when (n >= 20 && n <= 30):  
        Console.WriteLine("Arabanız hurdaya çıkabilir");
        break;

    default:
        Console.WriteLine("Geçersiz değer!");
        break;
}




Calisan[] calisanlar = new Calisan[4];

calisanlar[0] = new GenelMudur();
calisanlar[1] = new Stajyer();
calisanlar[2] = new Mudur();
calisanlar[3] = new Programci();

double toplamMaas = 0;

for (int k = 0; k < calisanlar.Length; k++)
{
    toplamMaas = toplamMaas + calisanlar[k].MaasHesapla();
}

Console.WriteLine("Tüm çalışanların toplam maaşı: " + toplamMaas + " TL");




Araclar[] araclar = new Araclar[4];

araclar[0] = new Honda();
araclar[1] = new BMW();
araclar[2] = new Toyata();
araclar[3] = new Mercedes();

double toplamTuketim = 0;

for (int h = 0; h < araclar.Length; h++)
{
    toplamTuketim += araclar[h].BenzinTuketimi();
}

Console.WriteLine("Araçlar toplam " + toplamTuketim + " litre benzin tüketti.");



// while döngüsü örneği:
// Bu örnekte kullanıcıdan belli bir sayıyı yazana kadar tekrar eden bir döngü yapmaya çalıştım.

int toplam = 0;
int sayi = -1;

while (sayi != 0)
{
    Console.Write("Bir sayı gir (çıkmak için 0): ");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
}

Console.WriteLine("Toplam: " + toplam);


// do-while döngüsü örneği:
// Bu örnekte ise kullanıcının belli bir şifreyi doğru girene kadar dönmesini istedim.

string sifre;

do
{
    Console.Write("Şifreyi gir: ");
    sifre = Console.ReadLine();
}
while (sifre != "1234");

Console.WriteLine("Giriş başarılı!");



