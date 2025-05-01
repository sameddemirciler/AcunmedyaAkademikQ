using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custom_Attribute_Ödevi.Attributes;

namespace Custom_Attribute_Ödevi.Models
{
    public class Ogrenci
    {
        [RequiredField("Öğrenci adı boş geçilemez.")] 
        public string Ad { get; set; }

        [RequiredField("Öğrenci soyadı boş geçilemez.")]
        public string Soyad { get; set; }

        [RequiredField("Öğrenci bölümü boş geçilemez.")]
        public string Bolum { get; set; }
    }
}
