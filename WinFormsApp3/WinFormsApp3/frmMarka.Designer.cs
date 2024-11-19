namespace WinFormsApp3
{
    partial class frmMarka
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            btnEkleMarka = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 23);
            textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(117, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 41);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Kategori :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 80);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 3;
            label2.Text = "Marka :";
            // 
            // btnEkleMarka
            // 
            btnEkleMarka.Location = new Point(123, 115);
            btnEkleMarka.Name = "btnEkleMarka";
            btnEkleMarka.Size = new Size(75, 23);
            btnEkleMarka.TabIndex = 4;
            btnEkleMarka.Text = "Ekle";
            btnEkleMarka.UseVisualStyleBackColor = true;
            btnEkleMarka.Click += btnEkleMarka_Click;
            // 
            // frmMarka
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(317, 178);
            Controls.Add(btnEkleMarka);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "frmMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Marka Sayfası";
            Load += frmMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button btnEkleMarka;
    }
}