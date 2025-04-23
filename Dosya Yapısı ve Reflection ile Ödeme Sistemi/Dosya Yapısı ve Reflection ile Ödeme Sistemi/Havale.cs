using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya_Yapısı_ve_Reflection_ile_Ödeme_Sistemi
{
    public class Havale : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Havale ile {tutar} TL gönderildi.";
        }
    }

}
