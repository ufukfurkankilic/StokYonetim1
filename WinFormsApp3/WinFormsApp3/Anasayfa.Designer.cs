namespace WinFormsApp3
{
    partial class Anasayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnMarka = new Button();
            btnKategori = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtToplamFiyat = new TextBox();
            txtSatışFiyatı = new TextBox();
            txtMiktar = new TextBox();
            txtÜrünAdı = new TextBox();
            txtBarkodNo = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            txtAdSoyad = new TextBox();
            lblGenelToplam = new Label();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtTelefon = new TextBox();
            txtTc = new TextBox();
            btnSatışİptal = new Button();
            btnSatışYap = new Button();
            label9 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMarka);
            panel1.Controls.Add(btnKategori);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 100);
            panel1.TabIndex = 19;
            panel1.Paint += panel1_Paint;
            // 
            // btnMarka
            // 
            btnMarka.Location = new Point(781, 27);
            btnMarka.Name = "btnMarka";
            btnMarka.Size = new Size(59, 43);
            btnMarka.TabIndex = 6;
            btnMarka.Text = "Marka";
            btnMarka.UseVisualStyleBackColor = true;
            btnMarka.Click += btnMarka_Click;
            // 
            // btnKategori
            // 
            btnKategori.Location = new Point(721, 27);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(59, 43);
            btnKategori.TabIndex = 5;
            btnKategori.Text = "Kategori";
            btnKategori.UseVisualStyleBackColor = true;
            btnKategori.Click += btnKategori_Click;
            // 
            // button9
            // 
            button9.Location = new Point(561, 27);
            button9.Name = "button9";
            button9.Size = new Size(114, 43);
            button9.TabIndex = 4;
            button9.Text = "Satışları Listeleme";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(417, 27);
            button8.Name = "button8";
            button8.Size = new Size(114, 43);
            button8.TabIndex = 3;
            button8.Text = "Ürün Listeleme";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(297, 27);
            button7.Name = "button7";
            button7.Size = new Size(114, 43);
            button7.TabIndex = 2;
            button7.Text = "Ürün Ekleme";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(149, 27);
            button6.Name = "button6";
            button6.Size = new Size(114, 43);
            button6.TabIndex = 1;
            button6.Text = "Müşteri Listeleme";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button12_Click;
            // 
            // button5
            // 
            button5.Location = new Point(32, 27);
            button5.Name = "button5";
            button5.Size = new Size(114, 43);
            button5.TabIndex = 0;
            button5.Text = "Müşteri Ekleme";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatışFiyatı);
            groupBox2.Controls.Add(txtMiktar);
            groupBox2.Controls.Add(txtÜrünAdı);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Location = new Point(0, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(220, 171);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 141);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 11;
            label8.Text = "Toplam Fiyat :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 112);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 10;
            label7.Text = "Satış Fiyatı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 83);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 9;
            label6.Text = "Miktarı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 54);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 8;
            label5.Text = "Ürün Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 25);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Barkod No :";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(101, 138);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(100, 23);
            txtToplamFiyat.TabIndex = 6;
            // 
            // txtSatışFiyatı
            // 
            txtSatışFiyatı.Location = new Point(101, 109);
            txtSatışFiyatı.Name = "txtSatışFiyatı";
            txtSatışFiyatı.Size = new Size(100, 23);
            txtSatışFiyatı.TabIndex = 5;
            txtSatışFiyatı.TextChanged += txtSatışFiyatı_TextChanged;
            // 
            // txtMiktar
            // 
            txtMiktar.Location = new Point(101, 80);
            txtMiktar.Name = "txtMiktar";
            txtMiktar.Size = new Size(100, 23);
            txtMiktar.TabIndex = 4;
            txtMiktar.Text = "1";
            txtMiktar.TextAlign = HorizontalAlignment.Center;
            txtMiktar.TextChanged += txtMiktar_TextChanged;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(101, 51);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(100, 23);
            txtÜrünAdı.TabIndex = 3;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(101, 22);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 3;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(226, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(538, 294);
            dataGridView1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 5;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 51);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Ad Soyad :";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(94, 52);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 1;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(525, 445);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(0, 15);
            lblGenelToplam.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTc);
            groupBox1.Location = new Point(7, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(213, 117);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 26);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 3;
            label1.Text = "TC :";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(94, 81);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 2;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(94, 23);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(100, 23);
            txtTc.TabIndex = 0;
            txtTc.TextChanged += txtTc_TextChanged;
            // 
            // btnSatışİptal
            // 
            btnSatışİptal.Location = new Point(770, 168);
            btnSatışİptal.Name = "btnSatışİptal";
            btnSatışİptal.Size = new Size(75, 23);
            btnSatışİptal.TabIndex = 15;
            btnSatışİptal.Text = "Satış İptal";
            btnSatışİptal.UseVisualStyleBackColor = true;
            btnSatışİptal.Click += btnSatışİptal_Click;
            // 
            // btnSatışYap
            // 
            btnSatışYap.Location = new Point(689, 439);
            btnSatışYap.Name = "btnSatışYap";
            btnSatışYap.Size = new Size(75, 23);
            btnSatışYap.TabIndex = 16;
            btnSatışYap.Text = "Satış Yap";
            btnSatışYap.UseVisualStyleBackColor = true;
            btnSatışYap.Click += btnSatışYap_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(438, 445);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 17;
            label9.Text = "Genel Toplam :";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(220, 439);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(770, 139);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // Anasayfa
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 517);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(lblGenelToplam);
            Controls.Add(groupBox1);
            Controls.Add(btnSatışİptal);
            Controls.Add(btnSatışYap);
            Controls.Add(label9);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Name = "Anasayfa";
            Text = "Anasayfa";
            Load += frmAnasayfa_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtToplamFiyat;
        private TextBox txtSatışFiyatı;
        private TextBox txtMiktar;
        private TextBox txtÜrünAdı;
        private TextBox txtBarkodNo;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label2;
        private TextBox txtAdSoyad;
        private Label lblGenelToplam;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtTelefon;
        private TextBox txtTc;
        private Button btnSatışİptal;
        private Button btnSatışYap;
        private Label label9;
        private Button btnEkle;
        private Button btnSil;
        private Button btnMarka;
        private Button btnKategori;
    }
}