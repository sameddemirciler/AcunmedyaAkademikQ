using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR19OOP.Interfaces;

namespace PR19OOP.Classes
{
    public class Bmw : Araba, HizliGider, HavadaUcar, DenizdeYüzer
    {
        public void DenizdeYüz(string isim)
        {
            Console.WriteLine(isim +" "+ "Denizde Yüzer...");
        }

        public void HavadaUc(string isim)
        {
            Console.WriteLine(isim +" "+ "Havada Uçar...");
        }

        public void HizliGİt(string isim)
        {
            Console.WriteLine(isim +" "+ "Çok Hızlı Gider...");
        }
    }
}
