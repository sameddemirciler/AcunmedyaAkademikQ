using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR19OOP.Abstracts
{
    public  abstract class Calisan
    {
        public  abstract double maasiniziNedir();

        public void mesaiyeBasla(string isim)
        {
            Console.WriteLine(isim + " mesaiye başladı");
        }
    }
}
