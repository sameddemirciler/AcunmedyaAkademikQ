using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List_ve_Nesne_Kullanımı_Ödevi___PRS
{
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; } // 100 km'de harcanan yakıt (litre)
        public double TotalDistance { get; set; } // Toplam gidilen mesafe (km)

        public double ToplamYakitTuketimi()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }
    }
}
