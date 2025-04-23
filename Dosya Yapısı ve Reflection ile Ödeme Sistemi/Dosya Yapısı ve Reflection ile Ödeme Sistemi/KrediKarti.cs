using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya_Yapısı_ve_Reflection_ile_Ödeme_Sistemi
{
    public class KrediKarti : IOdemeYontemi
    {
        public string Ode(decimal tutar)
        {
            return $"Kredi Kartı ile {tutar} TL ödendi.";
        }
    }

}
