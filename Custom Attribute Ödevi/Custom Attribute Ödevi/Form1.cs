using Custom_Attribute_Ödevi.Attributes;
using Custom_Attribute_Ödevi.Models;

namespace Custom_Attribute_Ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogrula_Click(object sender, EventArgs e)
        {
            var ogrenci = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Bolum = txtBolum.Text
            };

            var errors = ValidateProperties(ogrenci);

            if (errors.Any())
            {
                MessageBox.Show(string.Join("\n", errors), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblSonuc.Text = $"Öğrenci Bilgileri:\nAd: {ogrenci.Ad}\nSoyad: {ogrenci.Soyad}\nBölüm: {ogrenci.Bolum}";
            }
        }

        private string[] ValidateProperties(object obj)
        {
            var type = obj.GetType();
            var properties = type.GetProperties();

            return properties
                .Where(p => Attribute.IsDefined(p, typeof(RequiredFieldAttribute)))
                .Select(p =>
                {
                    var attribute = (RequiredFieldAttribute)Attribute.GetCustomAttribute(p, typeof(RequiredFieldAttribute));
                    var value = p.GetValue(obj) as string;

                    return string.IsNullOrWhiteSpace(value) ? attribute.ErrorMessage : null;
                })
                .Where(error => error != null)
                .ToArray();
        }
    }
}
