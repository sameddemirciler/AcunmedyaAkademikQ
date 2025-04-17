namespace ArabaBilgiFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBilgileriGoster_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            string kapiSayisi = txtKapiSayisi.Text;
            string pencereSayisi = txtPencereSayisi.Text;
            string yakitTuketimi = txtYakitTuketimi.Text;

            // Girilen bilgileri birleştirme
            string mesaj = $"Araba Bilgileri:\n" +
                           $"Marka: {marka}\n" +
                           $"Model: {model}\n" +
                           $"Renk: {renk}\n" +
                           $"Kapı Sayısı: {kapiSayisi}\n" +
                           $"Pencere Sayısı: {pencereSayisi}\n" +
                           $"100 km'de Yaktığı Yakıt: {yakitTuketimi} Litre";

            // Bilgileri kullanıcıya gösterme
            MessageBox.Show(mesaj, "Bilgiler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblMarka_Click(object sender, EventArgs e)
        {

        }
    }
}
