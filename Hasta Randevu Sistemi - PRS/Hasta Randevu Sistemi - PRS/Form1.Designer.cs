namespace Hasta_Randevu_Sistemi___PRS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbBrans = new ComboBox();
            cmbDoktor = new ComboBox();
            cmbSaat = new ComboBox();
            dtpTarih = new DateTimePicker();
            txtHastaAdi = new TextBox();
            txtHastaSoyadi = new TextBox();
            btnRandevuOlustur = new Button();
            SuspendLayout();
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(35, 37);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(151, 28);
            cmbBrans.TabIndex = 0;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(35, 86);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(151, 28);
            cmbDoktor.TabIndex = 1;
            // 
            // cmbSaat
            // 
            cmbSaat.FormattingEnabled = true;
            cmbSaat.Location = new Point(35, 139);
            cmbSaat.Name = "cmbSaat";
            cmbSaat.Size = new Size(151, 28);
            cmbSaat.TabIndex = 2;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(512, 35);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(250, 27);
            dtpTarih.TabIndex = 3;
            // 
            // txtHastaAdi
            // 
            txtHastaAdi.Location = new Point(35, 221);
            txtHastaAdi.Name = "txtHastaAdi";
            txtHastaAdi.Size = new Size(125, 27);
            txtHastaAdi.TabIndex = 4;
            // 
            // txtHastaSoyadi
            // 
            txtHastaSoyadi.Location = new Point(35, 274);
            txtHastaSoyadi.Name = "txtHastaSoyadi";
            txtHastaSoyadi.Size = new Size(125, 27);
            txtHastaSoyadi.TabIndex = 5;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(346, 344);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(94, 29);
            btnRandevuOlustur.TabIndex = 6;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(txtHastaSoyadi);
            Controls.Add(txtHastaAdi);
            Controls.Add(dtpTarih);
            Controls.Add(cmbSaat);
            Controls.Add(cmbDoktor);
            Controls.Add(cmbBrans);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBrans;
        private ComboBox cmbDoktor;
        private ComboBox cmbSaat;
        private DateTimePicker dtpTarih;
        private TextBox txtHastaAdi;
        private TextBox txtHastaSoyadi;
        private Button btnRandevuOlustur;
    }
}
