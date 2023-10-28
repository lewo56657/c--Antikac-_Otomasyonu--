namespace proje2
{
    partial class Kullanıcı_Bilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanıcı_Bilgileri));
            this.kullanıcı_isim_bilgisi = new System.Windows.Forms.TextBox();
            this.kullanıcı_email_bilgisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanıcı_bilgileri_güncelleme = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bilgilerimiGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanıcı_isim_bilgisi
            // 
            this.kullanıcı_isim_bilgisi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.kullanıcı_isim_bilgisi.Enabled = false;
            this.kullanıcı_isim_bilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_isim_bilgisi.Location = new System.Drawing.Point(294, 223);
            this.kullanıcı_isim_bilgisi.Multiline = true;
            this.kullanıcı_isim_bilgisi.Name = "kullanıcı_isim_bilgisi";
            this.kullanıcı_isim_bilgisi.Size = new System.Drawing.Size(235, 32);
            this.kullanıcı_isim_bilgisi.TabIndex = 0;
            this.kullanıcı_isim_bilgisi.TextChanged += new System.EventHandler(this.kullanıcı_isim_bilgisi_TextChanged);
            // 
            // kullanıcı_email_bilgisi
            // 
            this.kullanıcı_email_bilgisi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.kullanıcı_email_bilgisi.Enabled = false;
            this.kullanıcı_email_bilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_email_bilgisi.Location = new System.Drawing.Point(294, 304);
            this.kullanıcı_email_bilgisi.Multiline = true;
            this.kullanıcı_email_bilgisi.Name = "kullanıcı_email_bilgisi";
            this.kullanıcı_email_bilgisi.Size = new System.Drawing.Size(235, 32);
            this.kullanıcı_email_bilgisi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(107, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(107, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "E Mail";
            // 
            // kullanıcı_bilgileri_güncelleme
            // 
            this.kullanıcı_bilgileri_güncelleme.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.kullanıcı_bilgileri_güncelleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcı_bilgileri_güncelleme.Location = new System.Drawing.Point(239, 409);
            this.kullanıcı_bilgileri_güncelleme.Name = "kullanıcı_bilgileri_güncelleme";
            this.kullanıcı_bilgileri_güncelleme.Size = new System.Drawing.Size(190, 71);
            this.kullanıcı_bilgileri_güncelleme.TabIndex = 2;
            this.kullanıcı_bilgileri_güncelleme.Text = "Bilgilerimi Güncelle";
            this.kullanıcı_bilgileri_güncelleme.UseVisualStyleBackColor = false;
            this.kullanıcı_bilgileri_güncelleme.Visible = false;
            this.kullanıcı_bilgileri_güncelleme.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgilerimiGüncelleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 36);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bilgilerimiGüncelleToolStripMenuItem
            // 
            this.bilgilerimiGüncelleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bilgilerimiGüncelleToolStripMenuItem.Name = "bilgilerimiGüncelleToolStripMenuItem";
            this.bilgilerimiGüncelleToolStripMenuItem.Size = new System.Drawing.Size(193, 32);
            this.bilgilerimiGüncelleToolStripMenuItem.Text = "Bilgilerimi Güncelle";
            this.bilgilerimiGüncelleToolStripMenuItem.Click += new System.EventHandler(this.bilgilerimiGüncelleToolStripMenuItem_Click);
            // 
            // Kullanıcı_Bilgileri
            // 
            this.AcceptButton = this.kullanıcı_bilgileri_güncelleme;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 550);
            this.Controls.Add(this.kullanıcı_bilgileri_güncelleme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanıcı_email_bilgisi);
            this.Controls.Add(this.kullanıcı_isim_bilgisi);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Kullanıcı_Bilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı_Bilgileri";
            this.Load += new System.EventHandler(this.Kullanıcı_Bilgileri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kullanıcı_bilgileri_güncelleme;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bilgilerimiGüncelleToolStripMenuItem;
        public System.Windows.Forms.TextBox kullanıcı_isim_bilgisi;
        public System.Windows.Forms.TextBox kullanıcı_email_bilgisi;
    }
}