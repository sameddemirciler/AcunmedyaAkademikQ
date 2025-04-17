namespace ArabaBilgiFormu
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
            lblMarka = new Label();
            lblModel = new Label();
            lblRenk = new Label();
            txtMarka = new TextBox();
            txtModel = new TextBox();
            txtRenk = new TextBox();
            lblKapiSayisi = new Label();
            lblPencereSayisi = new Label();
            lblYakitTuketimi = new Label();
            txtYakitTuketimi = new TextBox();
            txtPencereSayisi = new TextBox();
            txtKapiSayisi = new TextBox();
            btnBilgileriGoster = new Button();
            SuspendLayout();
            // 
            // lblMarka
            // 
            lblMarka.AutoSize = true;
            lblMarka.Location = new Point(139, 89);
            lblMarka.Name = "lblMarka";
            lblMarka.Size = new Size(50, 20);
            lblMarka.TabIndex = 0;
            lblMarka.Text = "marka";
            lblMarka.Click += lblMarka_Click;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(139, 138);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(52, 20);
            lblModel.TabIndex = 1;
            lblModel.Text = "model";
            // 
            // lblRenk
            // 
            lblRenk.AutoSize = true;
            lblRenk.Location = new Point(139, 186);
            lblRenk.Name = "lblRenk";
            lblRenk.Size = new Size(37, 20);
            lblRenk.TabIndex = 2;
            lblRenk.Text = "renk";
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(298, 82);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(125, 27);
            txtMarka.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(298, 131);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 4;
            // 
            // txtRenk
            // 
            txtRenk.Location = new Point(298, 179);
            txtRenk.Name = "txtRenk";
            txtRenk.Size = new Size(125, 27);
            txtRenk.TabIndex = 5;
            // 
            // lblKapiSayisi
            // 
            lblKapiSayisi.AutoSize = true;
            lblKapiSayisi.Location = new Point(139, 239);
            lblKapiSayisi.Name = "lblKapiSayisi";
            lblKapiSayisi.Size = new Size(76, 20);
            lblKapiSayisi.TabIndex = 8;
            lblKapiSayisi.Text = "kapı sayısı";
            // 
            // lblPencereSayisi
            // 
            lblPencereSayisi.AutoSize = true;
            lblPencereSayisi.Location = new Point(139, 288);
            lblPencereSayisi.Name = "lblPencereSayisi";
            lblPencereSayisi.Size = new Size(101, 20);
            lblPencereSayisi.TabIndex = 7;
            lblPencereSayisi.Text = "pencere sayısı";
            // 
            // lblYakitTuketimi
            // 
            lblYakitTuketimi.AutoSize = true;
            lblYakitTuketimi.Location = new Point(139, 336);
            lblYakitTuketimi.Name = "lblYakitTuketimi";
            lblYakitTuketimi.Size = new Size(98, 20);
            lblYakitTuketimi.TabIndex = 6;
            lblYakitTuketimi.Text = "yakıt tüketimi";
            // 
            // txtYakitTuketimi
            // 
            txtYakitTuketimi.Location = new Point(298, 329);
            txtYakitTuketimi.Name = "txtYakitTuketimi";
            txtYakitTuketimi.Size = new Size(125, 27);
            txtYakitTuketimi.TabIndex = 11;
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(298, 281);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(125, 27);
            txtPencereSayisi.TabIndex = 10;
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(298, 232);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(125, 27);
            txtKapiSayisi.TabIndex = 9;
            // 
            // btnBilgileriGoster
            // 
            btnBilgileriGoster.Location = new Point(255, 396);
            btnBilgileriGoster.Name = "btnBilgileriGoster";
            btnBilgileriGoster.Size = new Size(158, 29);
            btnBilgileriGoster.TabIndex = 12;
            btnBilgileriGoster.Text = "bilgileri göster";
            btnBilgileriGoster.UseVisualStyleBackColor = true;
            btnBilgileriGoster.Click += btnBilgileriGoster_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBilgileriGoster);
            Controls.Add(txtYakitTuketimi);
            Controls.Add(txtPencereSayisi);
            Controls.Add(txtKapiSayisi);
            Controls.Add(lblKapiSayisi);
            Controls.Add(lblPencereSayisi);
            Controls.Add(lblYakitTuketimi);
            Controls.Add(txtRenk);
            Controls.Add(txtModel);
            Controls.Add(txtMarka);
            Controls.Add(lblRenk);
            Controls.Add(lblModel);
            Controls.Add(lblMarka);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarka;
        private Label lblModel;
        private Label lblRenk;
        private TextBox txtMarka;
        private TextBox txtModel;
        private TextBox txtRenk;
        private Label lblKapiSayisi;
        private Label lblPencereSayisi;
        private Label lblYakitTuketimi;
        private TextBox txtYakitTuketimi;
        private TextBox txtPencereSayisi;
        private TextBox txtKapiSayisi;
        private Button btnBilgileriGoster;
    }
}
