namespace proje2
{
    partial class ürün_sil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ürün_sil));
            this.silme_butonu = new System.Windows.Forms.Button();
            this.silinecek_urunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ürün_fiyati = new System.Windows.Forms.TextBox();
            this.urun_yapiliş_tarihi = new System.Windows.Forms.TextBox();
            this.urun_ismi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // silme_butonu
            // 
            this.silme_butonu.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.silme_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silme_butonu.Location = new System.Drawing.Point(641, 357);
            this.silme_butonu.Name = "silme_butonu";
            this.silme_butonu.Size = new System.Drawing.Size(128, 60);
            this.silme_butonu.TabIndex = 4;
            this.silme_butonu.Text = "Ürünü Sil";
            this.silme_butonu.UseVisualStyleBackColor = false;
            this.silme_butonu.Click += new System.EventHandler(this.silme_Click);
            // 
            // silinecek_urunler
            // 
            this.silinecek_urunler.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.silinecek_urunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.silinecek_urunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silinecek_urunler.HideSelection = false;
            this.silinecek_urunler.Location = new System.Drawing.Point(150, 52);
            this.silinecek_urunler.Name = "silinecek_urunler";
            this.silinecek_urunler.Size = new System.Drawing.Size(474, 115);
            this.silinecek_urunler.TabIndex = 17;
            this.silinecek_urunler.UseCompatibleStateImageBehavior = false;
            this.silinecek_urunler.View = System.Windows.Forms.View.Details;
            this.silinecek_urunler.SelectedIndexChanged += new System.EventHandler(this.silinecek_urunler_SelectedIndexChanged);
            this.silinecek_urunler.DoubleClick += new System.EventHandler(this.silinecek_urunler_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ıd";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 168;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapılış Tarihi";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyatı";
            this.columnHeader4.Width = 131;
            // 
            // ürün_fiyati
            // 
            this.ürün_fiyati.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ürün_fiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürün_fiyati.Location = new System.Drawing.Point(412, 341);
            this.ürün_fiyati.Name = "ürün_fiyati";
            this.ürün_fiyati.Size = new System.Drawing.Size(175, 27);
            this.ürün_fiyati.TabIndex = 2;
            this.ürün_fiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urun_yapiliş_tarihi
            // 
            this.urun_yapiliş_tarihi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.urun_yapiliş_tarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_yapiliş_tarihi.Location = new System.Drawing.Point(412, 274);
            this.urun_yapiliş_tarihi.Name = "urun_yapiliş_tarihi";
            this.urun_yapiliş_tarihi.Size = new System.Drawing.Size(175, 27);
            this.urun_yapiliş_tarihi.TabIndex = 1;
            this.urun_yapiliş_tarihi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // urun_ismi1
            // 
            this.urun_ismi1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.urun_ismi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun_ismi1.Location = new System.Drawing.Point(412, 213);
            this.urun_ismi1.Name = "urun_ismi1";
            this.urun_ismi1.Size = new System.Drawing.Size(175, 27);
            this.urun_ismi1.TabIndex = 0;
            this.urun_ismi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(241, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(241, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Yapılış Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(241, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Fiyatı";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(641, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ürün_sil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urun_ismi1);
            this.Controls.Add(this.urun_yapiliş_tarihi);
            this.Controls.Add(this.ürün_fiyati);
            this.Controls.Add(this.silinecek_urunler);
            this.Controls.Add(this.silme_butonu);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "ürün_sil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ürün_sil";
            this.Load += new System.EventHandler(this.ürün_sil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button silme_butonu;
        public System.Windows.Forms.ListView silinecek_urunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.TextBox ürün_fiyati;
        public System.Windows.Forms.TextBox urun_yapiliş_tarihi;
        public System.Windows.Forms.TextBox urun_ismi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
    }
}