using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExercies.classes
{
    public class Car
    {
        public string marka;
        public string model;
        public int kapiSayisi;
        public int pencereSayisi;
        public string vites;
        public void git(string marka, string model)
        {
            Console.WriteLine(marka+" "+model+" gidiyor..");
        }
        public void markaModel(string marka, string model)
        {
            Console.WriteLine("Arabanın markası:"+ " " + marka +" "+ "Modeli:" + model);
        }
        public void MarkaModelVites(string marka, string model, string vites)
        {
            Console.WriteLine("Arabanın markası:" + marka +" "+ "Arabanın Modeli:" + model +" "+ "Arabanın Vitesi:" +vites);
        }
        

    }
}
