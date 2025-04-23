namespace Dosya_Yapısı_ve_Reflection_ile_Ödeme_Sistemi
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
            btnKlasorSec = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            btnOde = new Button();
            labelSonuc = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnKlasorSec
            // 
            btnKlasorSec.Location = new Point(370, 231);
            btnKlasorSec.Name = "btnKlasorSec";
            btnKlasorSec.Size = new Size(94, 29);
            btnKlasorSec.TabIndex = 0;
            btnKlasorSec.Text = "Klasör Seç";
            btnKlasorSec.UseVisualStyleBackColor = true;
            btnKlasorSec.Click += btnKlasorSec_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Bottom;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 266);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(476, 184);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnOde
            // 
            btnOde.Location = new Point(182, 139);
            btnOde.Name = "btnOde";
            btnOde.Size = new Size(94, 29);
            btnOde.TabIndex = 4;
            btnOde.Text = "Öde";
            btnOde.UseVisualStyleBackColor = true;
            btnOde.Click += btnOde_Click;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(27, 9);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(101, 20);
            labelSonuc.TabIndex = 5;
            labelSonuc.Text = "Ödeme İşlemi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 6;
            label1.Text = "Ödeme Yöntemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 91);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Tutar :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 203);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 8;
            label3.Text = "Proje Dosyaları";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelSonuc);
            Controls.Add(btnOde);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(btnKlasorSec);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKlasorSec;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button btnOde;
        private Label labelSonuc;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
