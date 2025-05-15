using System.Data;
using System.Data.SqlClient;



namespace Hasta_Randevu_Sistemi___PRS
{
    




    public partial class Form1 : Form
    {


        string connectionString = "Server=.\\SQLEXPRESS;Database=RandevuDB;Trusted_Connection=True;";

        public Form1()
        {

            InitializeComponent();

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            ComboItem secilenBrans = (ComboItem)cmbBrans.SelectedItem;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, DoktorAdi, DoktorSoyadi FROM Doktorlar WHERE BransID = @BransID", conn);
                cmd.Parameters.AddWithValue("@BransID", secilenBrans.Value);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbDoktor.Items.Add(new ComboItem
                    {
                        Text = dr["DoktorAdi"] + " " + dr["DoktorSoyadi"],
                        Value = (int)dr["Id"]
                    });
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Id, BransAdi FROM Branslar", conn);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cmbBrans.Items.Add(new ComboItem
                    {
                        Text = dr["BransAdi"].ToString(),
                        Value = (int)dr["Id"]
                    });
                }
            }
            string[] saatler = { "09:00", "10:00", "11:00", "13:00", "14:00", "15:00" };
            cmbSaat.Items.AddRange(saatler);




        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdi.Text) || string.IsNullOrWhiteSpace(txtHastaSoyadi.Text))
            {
                MessageBox.Show("Lütfen hasta adı ve soyadını giriniz.");
                return;
            }

            if (cmbBrans.SelectedItem == null || cmbDoktor.SelectedItem == null || cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            ComboItem secilenBrans = (ComboItem)cmbBrans.SelectedItem;
            ComboItem secilenDoktor = (ComboItem)cmbDoktor.SelectedItem;
            DateTime tarihSaat = dtpTarih.Value.Date.Add(TimeSpan.Parse(cmbSaat.SelectedItem.ToString()));

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Randevu çakışma kontrolü
                SqlCommand kontrolCmd = new SqlCommand("SELECT COUNT(*) FROM Randevular WHERE DoktorID = @DoktorID AND Tarih = @Tarih", conn);
                kontrolCmd.Parameters.AddWithValue("@DoktorID", secilenDoktor.Value);
                kontrolCmd.Parameters.AddWithValue("@Tarih", tarihSaat);

                int mevcutRandevu = (int)kontrolCmd.ExecuteScalar();

                if (mevcutRandevu > 0)
                {
                    MessageBox.Show("Bu doktor için bu tarih ve saatte zaten bir randevu var.");
                    return;
                }

                // Yeni randevu kaydı
                SqlCommand ekleCmd = new SqlCommand(
                    "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) " +
                    "VALUES (@HastaAdi, @HastaSoyadi, @BransID, @DoktorID, @Tarih)", conn);

                ekleCmd.Parameters.AddWithValue("@HastaAdi", txtHastaAdi.Text);
                ekleCmd.Parameters.AddWithValue("@HastaSoyadi", txtHastaSoyadi.Text);
                ekleCmd.Parameters.AddWithValue("@BransID", secilenBrans.Value);
                ekleCmd.Parameters.AddWithValue("@DoktorID", secilenDoktor.Value);
                ekleCmd.Parameters.AddWithValue("@Tarih", tarihSaat);

                ekleCmd.ExecuteNonQuery();

                MessageBox.Show("Randevu başarıyla oluşturuldu.");
            }
        }
        public class ComboItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }


    }
}
