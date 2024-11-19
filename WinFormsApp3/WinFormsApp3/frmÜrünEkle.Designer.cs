namespace WinFormsApp3
{
    partial class frmÜrünEkle
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
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnYeniEkle = new Button();
            txtSatışFiyatı = new TextBox();
            txtAlışFiyatı = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboMarka = new ComboBox();
            comboKategori = new ComboBox();
            txtMiktarı = new TextBox();
            txtÜrünAdı = new TextBox();
            txtBarkodNo = new TextBox();
            groupBox2 = new GroupBox();
            btnVarOlanaEkle = new Button();
            label8 = new Label();
            Miktarıtxt = new TextBox();
            label9 = new Label();
            BarkodNotxt = new TextBox();
            label10 = new Label();
            ÜrünAdıtxt = new TextBox();
            label11 = new Label();
            SatışFiyatıtxt = new TextBox();
            label12 = new Label();
            Kategoritxt = new TextBox();
            label13 = new Label();
            AlışFiyatıtxt = new TextBox();
            label14 = new Label();
            Markatxt = new TextBox();
            lblÜrünMiktari = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(txtSatışFiyatı);
            groupBox1.Controls.Add(txtAlışFiyatı);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboMarka);
            groupBox1.Controls.Add(comboKategori);
            groupBox1.Controls.Add(txtMiktarı);
            groupBox1.Controls.Add(txtÜrünAdı);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Location = new Point(61, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(214, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 198);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 13;
            label7.Text = "Satış Fiyatı :";
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.Location = new Point(122, 238);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(75, 23);
            btnYeniEkle.TabIndex = 2;
            btnYeniEkle.Text = "Ekle";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // txtSatışFiyatı
            // 
            txtSatışFiyatı.Location = new Point(97, 190);
            txtSatışFiyatı.Name = "txtSatışFiyatı";
            txtSatışFiyatı.Size = new Size(100, 23);
            txtSatışFiyatı.TabIndex = 2;
            // 
            // txtAlışFiyatı
            // 
            txtAlışFiyatı.Location = new Point(97, 162);
            txtAlışFiyatı.Name = "txtAlışFiyatı";
            txtAlışFiyatı.Size = new Size(100, 23);
            txtAlışFiyatı.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 165);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "Alış Fiyatı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 138);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 11;
            label5.Text = "Miktarı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 109);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Ürün Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 83);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 9;
            label3.Text = "Marka :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 54);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Kategori :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 7;
            label1.Text = "Barkod No :";
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(97, 78);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(100, 23);
            comboMarka.TabIndex = 6;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(97, 50);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(100, 23);
            comboKategori.TabIndex = 5;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // txtMiktarı
            // 
            txtMiktarı.Location = new Point(97, 134);
            txtMiktarı.Name = "txtMiktarı";
            txtMiktarı.Size = new Size(100, 23);
            txtMiktarı.TabIndex = 4;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(97, 106);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(100, 23);
            txtÜrünAdı.TabIndex = 3;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(97, 22);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(100, 23);
            txtBarkodNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblÜrünMiktari);
            groupBox2.Controls.Add(btnVarOlanaEkle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(Miktarıtxt);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(BarkodNotxt);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(ÜrünAdıtxt);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(SatışFiyatıtxt);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(Kategoritxt);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(AlışFiyatıtxt);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(Markatxt);
            groupBox2.Location = new Point(281, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(228, 267);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürün";
            // 
            // btnVarOlanaEkle
            // 
            btnVarOlanaEkle.Location = new Point(127, 238);
            btnVarOlanaEkle.Name = "btnVarOlanaEkle";
            btnVarOlanaEkle.Size = new Size(75, 23);
            btnVarOlanaEkle.TabIndex = 3;
            btnVarOlanaEkle.Text = "Ekle";
            btnVarOlanaEkle.UseVisualStyleBackColor = true;
            btnVarOlanaEkle.Click += btnVarOlanaEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 198);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 20;
            label8.Text = "Satış Fiyatı :";
            // 
            // Miktarıtxt
            // 
            Miktarıtxt.Location = new Point(102, 135);
            Miktarıtxt.Name = "Miktarıtxt";
            Miktarıtxt.Size = new Size(100, 23);
            Miktarıtxt.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 165);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 19;
            label9.Text = "Alış Fiyatı :";
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(102, 22);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(100, 23);
            BarkodNotxt.TabIndex = 5;
            BarkodNotxt.TextChanged += BarkodNotxt_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 138);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 18;
            label10.Text = "Miktarı :";
            // 
            // ÜrünAdıtxt
            // 
            ÜrünAdıtxt.Location = new Point(102, 106);
            ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            ÜrünAdıtxt.Size = new Size(100, 23);
            ÜrünAdıtxt.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 109);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 17;
            label11.Text = "Ürün Adı :";
            // 
            // SatışFiyatıtxt
            // 
            SatışFiyatıtxt.Location = new Point(102, 193);
            SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            SatışFiyatıtxt.Size = new Size(100, 23);
            SatışFiyatıtxt.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(50, 83);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 16;
            label12.Text = "Marka :";
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(102, 51);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.Size = new Size(100, 23);
            Kategoritxt.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(39, 54);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 15;
            label13.Text = "Kategori :";
            // 
            // AlışFiyatıtxt
            // 
            AlışFiyatıtxt.Location = new Point(102, 164);
            AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            AlışFiyatıtxt.Size = new Size(100, 23);
            AlışFiyatıtxt.TabIndex = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(27, 25);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 14;
            label14.Text = "Barkod No :";
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(102, 80);
            Markatxt.Name = "Markatxt";
            Markatxt.Size = new Size(100, 23);
            Markatxt.TabIndex = 7;
            // 
            // lblÜrünMiktari
            // 
            lblÜrünMiktari.AutoSize = true;
            lblÜrünMiktari.Location = new Point(27, 238);
            lblÜrünMiktari.Name = "lblÜrünMiktari";
            lblÜrünMiktari.Size = new Size(0, 15);
            lblÜrünMiktari.TabIndex = 21;
            // 
            // frmÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(615, 362);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmÜrünEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekle";
            Load += frmÜrünEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSatışFiyatı;
        private TextBox txtAlışFiyatı;
        private TextBox txtBarkodNo;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboMarka;
        private ComboBox comboKategori;
        private TextBox txtMiktarı;
        private TextBox txtÜrünAdı;
        private TextBox Miktarıtxt;
        private TextBox BarkodNotxt;
        private TextBox ÜrünAdıtxt;
        private TextBox SatışFiyatıtxt;
        private TextBox Kategoritxt;
        private TextBox AlışFiyatıtxt;
        private TextBox Markatxt;
        private Button btnYeniEkle;
        private Button btnVarOlanaEkle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label lblÜrünMiktari;
    }
}