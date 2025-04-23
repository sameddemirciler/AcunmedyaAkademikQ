using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosya_Yapısı_ve_Reflection_ile_Ödeme_Sistemi
{
    public interface IOdemeYontemi
    {
        string Ode(decimal tutar);
    }
}
