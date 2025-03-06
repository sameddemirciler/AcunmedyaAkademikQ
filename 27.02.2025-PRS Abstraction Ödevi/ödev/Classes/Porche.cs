using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR19OOP.Interfaces;

namespace PR19OOP.Classes
{
    public class Porche : Araba, HavadaUcar
    {
        public void HavadaUc(string isim)
        {
            Console.WriteLine(isim + " " + "Havada Uçar...");
        }
    }
}
