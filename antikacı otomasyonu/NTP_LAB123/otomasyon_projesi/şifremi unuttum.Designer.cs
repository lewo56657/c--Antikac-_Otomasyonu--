namespace proje2
{
    partial class şifremi_unuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(şifremi_unuttum));
            this.Değiştirilecek_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yeni_şifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Yeni_şifre_tekrar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Değiştirilecek_email
            // 
            this.Değiştirilecek_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Değiştirilecek_email.Location = new System.Drawing.Point(146, 85);
            this.Değiştirilecek_email.Multiline = true;
            this.Değiştirilecek_email.Name = "Değiştirilecek_email";
            this.Değiştirilecek_email.Size = new System.Drawing.Size(200, 38);
            this.Değiştirilecek_email.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(188, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "E MAİL";
            // 
            // yeni_şifre
            // 
            this.yeni_şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeni_şifre.Location = new System.Drawing.Point(145, 261);
            this.yeni_şifre.Multiline = true;
            this.yeni_şifre.Name = "yeni_şifre";
            this.yeni_şifre.Size = new System.Drawing.Size(200, 38);
            this.yeni_şifre.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(141, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yeni Şifrenizi Giriniz";
            // 
            // Yeni_şifre_tekrar
            // 
            this.Yeni_şifre_tekrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yeni_şifre_tekrar.Location = new System.Drawing.Point(145, 414);
            this.Yeni_şifre_tekrar.Multiline = true;
            this.Yeni_şifre_tekrar.Name = "Yeni_şifre_tekrar";
            this.Yeni_şifre_tekrar.Size = new System.Drawing.Size(200, 38);
            this.Yeni_şifre_tekrar.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(104, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(275, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Yeni Şifrenizi Tekrar Giriniz";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(145, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 66);
            this.button1.TabIndex = 17;
            this.button1.Text = "Şifremi Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // şifremi_unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 640);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Yeni_şifre_tekrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yeni_şifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Değiştirilecek_email);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Name = "şifremi_unuttum";
            this.Text = "şifremi_unuttum";
            this.Load += new System.EventHandler(this.şifremi_unuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Değiştirilecek_email;
        public System.Windows.Forms.TextBox yeni_şifre;
        public System.Windows.Forms.TextBox Yeni_şifre_tekrar;
    }
}