namespace proje2
{
    partial class YÖNETİCİ_GİRİŞİ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YÖNETİCİ_GİRİŞİ));
            this.button1 = new System.Windows.Forms.Button();
            this.yönetici_ismi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yönetici_şifresi1 = new System.Windows.Forms.TextBox();
            this.yönetici_giriş_kodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(175, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yönetici_ismi1
            // 
            this.yönetici_ismi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yönetici_ismi1.Location = new System.Drawing.Point(147, 68);
            this.yönetici_ismi1.Multiline = true;
            this.yönetici_ismi1.Name = "yönetici_ismi1";
            this.yönetici_ismi1.Size = new System.Drawing.Size(184, 41);
            this.yönetici_ismi1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(167, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yönetici ismi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(158, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yönetici Şifresi";
            // 
            // yönetici_şifresi1
            // 
            this.yönetici_şifresi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yönetici_şifresi1.Location = new System.Drawing.Point(147, 213);
            this.yönetici_şifresi1.Multiline = true;
            this.yönetici_şifresi1.Name = "yönetici_şifresi1";
            this.yönetici_şifresi1.PasswordChar = '*';
            this.yönetici_şifresi1.Size = new System.Drawing.Size(184, 41);
            this.yönetici_şifresi1.TabIndex = 1;
            // 
            // yönetici_giriş_kodu
            // 
            this.yönetici_giriş_kodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yönetici_giriş_kodu.Location = new System.Drawing.Point(147, 364);
            this.yönetici_giriş_kodu.Multiline = true;
            this.yönetici_giriş_kodu.Name = "yönetici_giriş_kodu";
            this.yönetici_giriş_kodu.PasswordChar = '*';
            this.yönetici_giriş_kodu.Size = new System.Drawing.Size(184, 41);
            this.yönetici_giriş_kodu.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(167, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giriş Kodu\r\n";
            // 
            // YÖNETİCİ_GİRİŞİ
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yönetici_giriş_kodu);
            this.Controls.Add(this.yönetici_şifresi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yönetici_ismi1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "YÖNETİCİ_GİRİŞİ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox yönetici_ismi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yönetici_şifresi1;
        private System.Windows.Forms.TextBox yönetici_giriş_kodu;
        private System.Windows.Forms.Label label4;
    }
}