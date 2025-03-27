using Generic_List_ve_Nesne_Kullanımı_Ödevi___PRS;
using System.Collections.Generic;

List<Car> arabalar = new List<Car>
{
    new Car { Marka = "Toyota", Model = "Corolla", FuelConsumption = 6.5, TotalDistance = 5000 },
    new Car { Marka = "BMW", Model = "X5", FuelConsumption = 9.0, TotalDistance = 5000 },
    new Car { Marka = "Mercedes", Model = "C200", FuelConsumption = 8.2, TotalDistance = 5000 }
};

foreach (var araba in arabalar)
{
    double toplamYakit = araba.ToplamYakitTuketimi();
    Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}, 100 km'de Yaktığı Yakıt: {araba.FuelConsumption} litre, Toplam Yakıt Tüketimi: {toplamYakit} litre");
}

Console.ReadLine();





// Görsel Programlama Nedir?
//Günümüzde yazılım geliştirme süreci, sadece metin tabanlı komutlardan ibaret değildir.
//Özellikle eğitim, prototipleme ve hızlı uygulama geliştirme alanlarında görsel programlama yöntemleri yaygınlaşmıştır.
//Bu yaklaşım, yazılım geliştirmeyi daha erişilebilir ve anlaşılır hale getirmeyi amaçlar.


//Görsel programlama kavramını tanımlayın.
//kullanıcıların programları oluşturmak için grafiksel öğeler (bloklar, akış diyagramları, simgeler, düğmeler vb.) kullandığı bir programlama yöntemidir.
//Kod yazmak yerine, kullanıcılar sürükle-bırak yöntemiyle görsel bileşenleri bir araya getirerek mantıksal akışlar oluştururlar.
//Örneğin, Scratch, Blockly, App Inventor gibi araçlar görsel programlamanın popüler örnekleridir. Bu araçlarda, döngüler, koşullar, fonksiyonlar gibi temel programlama yapıları bloklar halinde sunulur ve birleştirilerek algoritmalar inşa edilir.


//Metin tabanlı programlamadan farkları nelerdir?
//Görsel programlama, kod yazmak yerine blokları sürükleyip bırakarak işlem yapmayı sağlar.
//Bu yönüyle metin tabanlı programlamadan ayrılır.
//Metin tabanlı programlamada komutlar yazıyla ifade edilir ve doğru sözdizimi kullanmak gerekir.
//Görsel programlama ise görsellerle çalıştığı için yeni başlayanlar için daha kolaydır ve yazım hatası yapma riski düşüktür.
//Ayrıca, görsel programlama daha basit uygulamalar için uygundur.
//Metin tabanlı programlama ise daha karmaşık ve detaylı projelerde tercih edilir çünkü daha fazla kontrol ve esneklik sunar.
//Hatalar da farklı şekilde görülür; görsel programlamada bloklar üzerinden anlaşılırken, metin tabanlı programlamada hata mesajları yazıyla gösterilir.
//Sonuç olarak, görsel programlama öğrenmesi kolay ve eğlenceli bir yöntemdir, ancak profesyonel yazılım geliştirme için metin tabanlı programlama daha uygundur.
