namespace Serialization___Deserialization___PRS
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
            btnUrunleriGoster = new Button();
            lstUrunler = new ListBox();
            SuspendLayout();
            // 
            // btnUrunleriGoster
            // 
            btnUrunleriGoster.Location = new Point(280, 39);
            btnUrunleriGoster.Name = "btnUrunleriGoster";
            btnUrunleriGoster.Size = new Size(179, 29);
            btnUrunleriGoster.TabIndex = 0;
            btnUrunleriGoster.Text = "Ürünleri Göster";
            btnUrunleriGoster.UseVisualStyleBackColor = true;
            btnUrunleriGoster.Click += btnUrunleriGoster_Click;
            // 
            // lstUrunler
            // 
            lstUrunler.FormattingEnabled = true;
            lstUrunler.Location = new Point(295, 132);
            lstUrunler.Name = "lstUrunler";
            lstUrunler.Size = new Size(150, 104);
            lstUrunler.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstUrunler);
            Controls.Add(btnUrunleriGoster);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUrunleriGoster;
        private ListBox lstUrunler;
    }
}
