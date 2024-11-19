namespace WinFormsApp3
{
    partial class frmÜrünListele
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
            dataGridView1 = new DataGridView();
            lblÜrünMiktari = new Label();
            btnGüncelle = new Button();
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
            btnSil = new Button();
            label1 = new Label();
            txtBarkodNoAra = new TextBox();
            comboKategori = new ComboBox();
            comboMarka = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMarkaGüncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(296, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(453, 212);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // lblÜrünMiktari
            // 
            lblÜrünMiktari.AutoSize = true;
            lblÜrünMiktari.Location = new Point(43, 258);
            lblÜrünMiktari.Name = "lblÜrünMiktari";
            lblÜrünMiktari.Size = new Size(0, 15);
            lblÜrünMiktari.TabIndex = 37;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(143, 242);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 22;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 218);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 36;
            label8.Text = "Satış Fiyatı :";
            // 
            // Miktarıtxt
            // 
            Miktarıtxt.Location = new Point(118, 155);
            Miktarıtxt.Name = "Miktarıtxt";
            Miktarıtxt.Size = new Size(100, 23);
            Miktarıtxt.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(49, 185);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 35;
            label9.Text = "Alış Fiyatı :";
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(118, 42);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(100, 23);
            BarkodNotxt.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 158);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 34;
            label10.Text = "Miktarı :";
            // 
            // ÜrünAdıtxt
            // 
            ÜrünAdıtxt.Location = new Point(118, 126);
            ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            ÜrünAdıtxt.Size = new Size(100, 23);
            ÜrünAdıtxt.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(52, 129);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 33;
            label11.Text = "Ürün Adı :";
            // 
            // SatışFiyatıtxt
            // 
            SatışFiyatıtxt.Location = new Point(118, 213);
            SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            SatışFiyatıtxt.Size = new Size(100, 23);
            SatışFiyatıtxt.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(66, 103);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 32;
            label12.Text = "Marka :";
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(118, 71);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.ReadOnly = true;
            Kategoritxt.Size = new Size(100, 23);
            Kategoritxt.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(55, 74);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 31;
            label13.Text = "Kategori :";
            // 
            // AlışFiyatıtxt
            // 
            AlışFiyatıtxt.Location = new Point(118, 184);
            AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            AlışFiyatıtxt.Size = new Size(100, 23);
            AlışFiyatıtxt.TabIndex = 24;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(43, 45);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 30;
            label14.Text = "Barkod No :";
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(118, 100);
            Markatxt.Name = "Markatxt";
            Markatxt.ReadOnly = true;
            Markatxt.Size = new Size(100, 23);
            Markatxt.TabIndex = 27;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(751, 49);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(47, 23);
            btnSil.TabIndex = 38;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(514, 16);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 39;
            label1.Text = "Barkod No İle Ara :";
            // 
            // txtBarkodNoAra
            // 
            txtBarkodNoAra.Location = new Point(619, 13);
            txtBarkodNoAra.Name = "txtBarkodNoAra";
            txtBarkodNoAra.Size = new Size(100, 23);
            txtBarkodNoAra.TabIndex = 40;
            txtBarkodNoAra.TextChanged += txtBarkodNoAra_TextChanged;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(347, 290);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(99, 23);
            comboKategori.TabIndex = 41;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(347, 318);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(99, 23);
            comboMarka.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 319);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 44;
            label2.Text = "Marka :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 290);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 43;
            label3.Text = "Kategori :";
            // 
            // btnMarkaGüncelle
            // 
            btnMarkaGüncelle.Location = new Point(452, 293);
            btnMarkaGüncelle.Name = "btnMarkaGüncelle";
            btnMarkaGüncelle.Size = new Size(75, 48);
            btnMarkaGüncelle.TabIndex = 45;
            btnMarkaGüncelle.Text = "Marka Güncelle";
            btnMarkaGüncelle.UseVisualStyleBackColor = true;
            btnMarkaGüncelle.Click += btnMarkaGüncelle_Click;
            // 
            // frmÜrünListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(810, 372);
            Controls.Add(btnMarkaGüncelle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboMarka);
            Controls.Add(comboKategori);
            Controls.Add(txtBarkodNoAra);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(lblÜrünMiktari);
            Controls.Add(btnGüncelle);
            Controls.Add(label8);
            Controls.Add(Miktarıtxt);
            Controls.Add(label9);
            Controls.Add(BarkodNotxt);
            Controls.Add(label10);
            Controls.Add(ÜrünAdıtxt);
            Controls.Add(label11);
            Controls.Add(SatışFiyatıtxt);
            Controls.Add(label12);
            Controls.Add(Kategoritxt);
            Controls.Add(label13);
            Controls.Add(AlışFiyatıtxt);
            Controls.Add(label14);
            Controls.Add(Markatxt);
            Controls.Add(dataGridView1);
            Name = "frmÜrünListele";
            Text = "Ürün Listeleme Sayfası";
            Load += frmÜrünListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblÜrünMiktari;
        private Button btnGüncelle;
        private Label label8;
        private TextBox Miktarıtxt;
        private Label label9;
        private TextBox BarkodNotxt;
        private Label label10;
        private TextBox ÜrünAdıtxt;
        private Label label11;
        private TextBox SatışFiyatıtxt;
        private Label label12;
        private TextBox Kategoritxt;
        private Label label13;
        private TextBox AlışFiyatıtxt;
        private Label label14;
        private TextBox Markatxt;
        private Button btnSil;
        private Label label1;
        private TextBox txtBarkodNoAra;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGüncelle;
    }
}