namespace WinFormsApp3
{
    partial class frmMüşteriEkle
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTC = new TextBox();
            txtAdSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtAdres = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(127, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 54);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "TC :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 89);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Telefon :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 159);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Adres :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 194);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "E-mail :";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(118, 51);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 6;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(118, 86);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(100, 23);
            txtAdSoyad.TabIndex = 7;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(118, 121);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 8;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(118, 156);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(100, 23);
            txtAdres.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 10;
            // 
            // frmMüşteriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(316, 301);
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
            Controls.Add(button1);
            Name = "frmMüşteriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Ekleme Sayfası";
            Load += frmMüşteriEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTC;
        private TextBox txtAdSoyad;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private TextBox txtEmail;
    }
}