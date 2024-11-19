namespace WinFormsApp3
{
    partial class frmMüşteriListele
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
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGüncelle = new Button();
            btnSil = new Button();
            txtTcAra = new TextBox();
            lvlTcAra = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(205, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 209);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(99, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 21;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(99, 185);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 20;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(99, 150);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 19;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(99, 115);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 18;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(99, 80);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 223);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 16;
            label5.Text = "E-mail :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 188);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 15;
            label4.Text = "Adres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 14;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 118);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 13;
            label2.Text = "Ad Soyad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 83);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 12;
            label1.Text = "TC :";
            label1.Click += label1_Click;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(108, 249);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(75, 23);
            btnGüncelle.TabIndex = 11;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(723, 73);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(65, 23);
            btnSil.TabIndex = 22;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(563, 41);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(100, 23);
            txtTcAra.TabIndex = 23;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // lvlTcAra
            // 
            lvlTcAra.AutoSize = true;
            lvlTcAra.Location = new Point(510, 44);
            lvlTcAra.Name = "lvlTcAra";
            lvlTcAra.Size = new Size(47, 15);
            lvlTcAra.TabIndex = 24;
            lvlTcAra.Text = "TC Ara :";
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 342);
            Controls.Add(lvlTcAra);
            Controls.Add(txtTcAra);
            Controls.Add(btnSil);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGüncelle);
            Controls.Add(dataGridView1);
            Name = "frmMüşteriListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüşteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGüncelle;
        private Button btnSil;
        private TextBox txtTcAra;
        private Label lvlTcAra;
    }
}