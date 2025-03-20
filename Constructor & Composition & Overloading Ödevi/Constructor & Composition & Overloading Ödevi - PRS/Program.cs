using System;
using Constructor___Composition___Overloading_Ödevi___PRS.Constructors;
using Constructor___Composition___Overloading_Ödevi___PRS;
using System.Runtime.ConstrainedExecution;
using System.Diagnostics.Metrics;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Marka marka = new Marka("BMW");
            Model model = new Model("X5");
            Pencere pencere = new Pencere(4);
            Kapi kapi = new Kapi(4);
            Kasa kasa = new Kasa("Sedan");
            double fiyat = 2000000;

            Araba araba = new Araba(marka, model, kapi, pencere, kasa, fiyat);
            araba.arabaKaydet();

            Matematik mat = new Matematik();

            Console.WriteLine("Toplamalar:");
            Console.WriteLine("İki int: " + mat.Topla(5, 11));
            Console.WriteLine("Üç int: " + mat.Topla(5, 13, 15));
            Console.WriteLine("İki double: " + mat.Topla(5.5, 10.2));
            Console.WriteLine("Üç double: " + mat.Topla(1.1, 2.2, 3.3));

            Console.WriteLine("\nÇarpmalar:");
            Console.WriteLine("İki int: " + mat.Carp(2, 3));
            Console.WriteLine("Üç int: " + mat.Carp(2, 3, 4));
            Console.WriteLine("İki double: " + mat.Carp(1.5, 2.0));
            Console.WriteLine("Üç double: " + mat.Carp(1.1, 2.2, 3.3));

            Console.ReadLine();
        }

        //- Garbage Collector (GC) nedir ve nasıl çalışır:
        //C#'da Garbage Collector (GC), kullanılan nesneleri otomatik olarak yönetir ve artık erişilemeyen nesneleri bellekten temizleyerek RAM’i boşaltır.
        //Kuşaklar(Generations) mantığıyla çalışır ve genellikle arka planda otomatik devreye girer.


        //- Bellek yönetimindeki rolü nedir:
        //Garbage Collector (GC), C#’da bellek yönetimini otomatikleştirir. Kullanılmayan nesneleri tespit edip bellekten temizleyerek RAM’in verimli kullanılmasını sağlar ve bellek sızıntılarını (memory leaks) önler.





        // Generic yapıların avantajlarını araştırın:
        //Generic yapılar, farklı veri tipleriyle çalışan ve tip güvenliği sağlayan sınıf ve metotlardır.
        // Avantajları:
        //Tip güvenliği sağlar.
        //Kod tekrarını azaltır.
        //Boxing ve unboxing’i önleyerek performansı artırır.
        //Esnek ve yeniden kullanılabilir kod yazmayı sağlar.


        //- Generic sınıf ve metotlarla esnek programlama nasıl yapılır:
        //Generic sınıf ve metotlarla, farklı veri tipleriyle çalışan tek bir kod yapısı oluşturulur. Bu, tip bağımsız ve esnek programlama sağlar.
        //Tip parametresi (<T>) kullanılarak, sınıf veya metot farklı veri türlerini destekler.
        //Her tür için ayrı ayrı kod yazmaya gerek kalmaz, genel ve esnek bir yapı oluşturulur.



        //- Boxing & Unboxing nedir ve performansa etkisi nedir:
        //Boxing, bir değer tipinin(ör. int, bool) object gibi referans tipine dönüştürülmesidir.
        //Unboxing, bu referans tipinden tekrar değer tipine dönüştürme işlemidir.

    }
}
