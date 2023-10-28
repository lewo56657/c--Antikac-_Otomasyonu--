namespace proje2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_ismi1 = new System.Windows.Forms.TextBox();
            this.E_MAİL = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.KAYIT_OL = new System.Windows.Forms.Button();
            this.İLKŞİFRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(115, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(115, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-Posta :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kullanici_ismi1
            // 
            this.kullanici_ismi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.kullanici_ismi1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kullanici_ismi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_ismi1.Location = new System.Drawing.Point(118, 137);
            this.kullanici_ismi1.Multiline = true;
            this.kullanici_ismi1.Name = "kullanici_ismi1";
            this.kullanici_ismi1.Size = new System.Drawing.Size(274, 39);
            this.kullanici_ismi1.TabIndex = 0;
            this.kullanici_ismi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kullanici_ismi1.TextChanged += new System.EventHandler(this.kullanici_ismi1_TextChanged);
            // 
            // E_MAİL
            // 
            this.E_MAİL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.E_MAİL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.E_MAİL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.E_MAİL.ForeColor = System.Drawing.SystemColors.WindowText;
            this.E_MAİL.Location = new System.Drawing.Point(118, 276);
            this.E_MAİL.Multiline = true;
            this.E_MAİL.Name = "E_MAİL";
            this.E_MAİL.Size = new System.Drawing.Size(274, 39);
            this.E_MAİL.TabIndex = 1;
            this.E_MAİL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(163, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = " Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KAYIT_OL
            // 
            this.KAYIT_OL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KAYIT_OL.Location = new System.Drawing.Point(163, 453);
            this.KAYIT_OL.Name = "KAYIT_OL";
            this.KAYIT_OL.Size = new System.Drawing.Size(135, 59);
            this.KAYIT_OL.TabIndex = 3;
            this.KAYIT_OL.Text = "KAYIT OL";
            this.KAYIT_OL.UseVisualStyleBackColor = true;
            this.KAYIT_OL.Click += new System.EventHandler(this.button3_Click);
            // 
            // İLKŞİFRE
            // 
            this.İLKŞİFRE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.İLKŞİFRE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.İLKŞİFRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İLKŞİFRE.Location = new System.Drawing.Point(120, 398);
            this.İLKŞİFRE.Multiline = true;
            this.İLKŞİFRE.Name = "İLKŞİFRE";
            this.İLKŞİFRE.PasswordChar = '*';
            this.İLKŞİFRE.Size = new System.Drawing.Size(272, 39);
            this.İLKŞİFRE.TabIndex = 2;
            this.İLKŞİFRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(115, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre Oluştur : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zaten Bir Hesabın Varmı?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 623);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.İLKŞİFRE);
            this.Controls.Add(this.KAYIT_OL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.E_MAİL);
            this.Controls.Add(this.kullanici_ismi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "şifremi unuttum";
            this.Load += new System.EventHandler(this.KULLANICI_GİRİŞ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullanici_ismi1;
        private System.Windows.Forms.TextBox E_MAİL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox İLKŞİFRE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button KAYIT_OL;
    }
}

