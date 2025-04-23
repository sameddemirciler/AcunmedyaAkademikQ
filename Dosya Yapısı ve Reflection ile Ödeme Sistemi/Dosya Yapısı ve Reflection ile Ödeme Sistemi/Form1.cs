using System.Reflection;

namespace Dosya_Yapısı_ve_Reflection_ile_Ödeme_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlasorSec_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string secilenKlasor = dialog.SelectedPath;
                    KlasorleriListele(secilenKlasor);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bu assembly içindeki tüm tipleri alıyoruz
            var odemeTipleri = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) // IOdemeYontemi interface'ini implemente edenler
                            && !t.IsInterface  // Interface’in kendisi değil
                            && !t.IsAbstract); // Soyut sınıf değil

            // ComboBox'a bu tipleri ekliyoruz
            foreach (var tip in odemeTipleri)
            {
                comboBox1.Items.Add(tip);
            }

            comboBox1.DisplayMember = "Name"; // ComboBox'ta sınıf isimleri görünsün
        }

        private void KlasorleriListele(string anaKlasor)
        {
            listBox1.Items.Clear();

            string[] altKlasorler = Directory.GetDirectories(anaKlasor);

            foreach (var klasor in altKlasorler)
            {
                string klasorAdi = "📁 " + Path.GetFileName(klasor);
                listBox1.Items.Add(klasorAdi);

                string[] csDosyalari = Directory.GetFiles(klasor, "*.cs");

                foreach (var dosya in csDosyalari)
                {
                    string[] satirlar = File.ReadAllLines(dosya);

                    foreach (var satir in satirlar)
                    {
                        string temizSatir = satir.Trim();

                        if (temizSatir.StartsWith("class "))
                        {
                            string[] kelimeler = temizSatir.Split(' ');
                            int classIndex = Array.IndexOf(kelimeler, "class");

                            if (classIndex != -1 && classIndex < kelimeler.Length - 1)
                            {
                                string classAdi = kelimeler[classIndex + 1];
                                listBox1.Items.Add("   📄 " + classAdi);
                            }
                        }
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Type secilenTip && decimal.TryParse(textBox1.Text, out decimal tutar))
            {
                // Seçilen sınıfın nesnesini oluştur
                var odemeNesnesi = Activator.CreateInstance(secilenTip) as IOdemeYontemi;

                // Ode() metodunu çağır ve sonucu yazdır
                string sonuc = odemeNesnesi?.Ode(tutar);
                labelSonuc.Text = sonuc;
            }
            else
            {
                labelSonuc.Text = "Lütfen geçerli bir tutar ve yöntem seçiniz.";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }









}
