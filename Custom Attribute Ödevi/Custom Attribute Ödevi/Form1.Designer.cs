namespace Custom_Attribute_Ödevi
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
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBolum = new TextBox();
            lblAd = new Label();
            lblSoyad = new Label();
            lblBolum = new Label();
            btnDogrula = new Button();
            lblSonuc = new Label();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(177, 50);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(177, 95);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 1;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(177, 138);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 2;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(31, 50);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(91, 20);
            lblAd.TabIndex = 3;
            lblAd.Text = "Öğrenci Adı:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(31, 98);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(113, 20);
            lblSoyad.TabIndex = 4;
            lblSoyad.Text = "Öğrenci Soyadı:";
            // 
            // lblBolum
            // 
            lblBolum.AutoSize = true;
            lblBolum.Location = new Point(31, 145);
            lblBolum.Name = "lblBolum";
            lblBolum.Size = new Size(119, 20);
            lblBolum.TabIndex = 5;
            lblBolum.Text = "Öğrenci Bölümü:";
            // 
            // btnDogrula
            // 
            btnDogrula.Location = new Point(110, 199);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(192, 29);
            btnDogrula.TabIndex = 6;
            btnDogrula.Text = "Bilgileri Doğrula";
            btnDogrula.UseVisualStyleBackColor = true;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(468, 95);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(119, 20);
            lblSonuc.TabIndex = 7;
            lblSonuc.Text = "Öğrenci Bölümü:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSonuc);
            Controls.Add(btnDogrula);
            Controls.Add(lblBolum);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBolum;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblBolum;
        private Button btnDogrula;
        private Label lblSonuc;
    }
}
