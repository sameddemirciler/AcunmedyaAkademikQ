using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor___Composition___Overloading_Ödevi___PRS.Constructors
{
    public class Araba
    {
        public double fiyat;
        private Marka marka;
        private Model model;
        private Kapi kapi;
        private Pencere pencere;
        private Kasa kasa;

        public Araba(Marka marka, Model model, double fiyat) 
        {
            this.fiyat = fiyat;
        }

        public Araba(Marka marka, Model model, Kapi kapi, Pencere pencere, Kasa kasa, double fiyat)
        {
            this.marka = marka;
            this.model = model;
            this.kapi = kapi;
            this.pencere = pencere;
            this.kasa = kasa;
            this.fiyat = fiyat;
        }

        public void arabaKaydet()
        {
            Console.WriteLine("Arabanın markası :" + marka.markaAdi+ " ," +
                "modeli :" + model.modelIsim +" ,"+
                "kapı sayısı :" + kapi.Kapisayisi +" ,"+
                "pencere sayısı :" + pencere.Penceresayisi +" ,"+
                "kasası :" + kasa.Kasatipi +" ,"+
                "fiyat :" + fiyat);
        }
    }
}
