using System.Text.Json;
using System.IO;
using System.Collections.Generic;
namespace Serialization___Deserialization___PRS

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            try
            {
                // JSON dosyasını okuma
                string jsonDosyasi = File.ReadAllText("urunler.json");

                // JSON verisini deserialization ile nesneye dönüştürme
                List<Urun> urunler = JsonSerializer.Deserialize<List<Urun>>(jsonDosyasi);

                // ListBox'ı temizleme
                lstUrunler.Items.Clear();

                // Her ürünü ListBox'a ekleme
                foreach (var urun in urunler)
                {
                    lstUrunler.Items.Add($"{urun.UrunAdi} - {urun.Fiyat} TL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
