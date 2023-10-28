namespace proje2
{
    partial class sepet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sepet));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.sepet_listesi = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YapılıTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sepet_boşaltma = new System.Windows.Forms.Button();
            this.Toplam_fiyat = new System.Windows.Forms.TextBox();
            this.ürün_sayısı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sepet_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(466, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Satın Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sepet_listesi
            // 
            this.sepet_listesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sepet_listesi.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.sepet_listesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sepet_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sepet_listesi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.adı,
            this.YapılıTarihi,
            this.Column1});
            this.sepet_listesi.Location = new System.Drawing.Point(197, 35);
            this.sepet_listesi.Name = "sepet_listesi";
            this.sepet_listesi.RowHeadersWidth = 51;
            this.sepet_listesi.RowTemplate.Height = 24;
            this.sepet_listesi.Size = new System.Drawing.Size(591, 261);
            this.sepet_listesi.TabIndex = 15;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // adı
            // 
            this.adı.HeaderText = "adı";
            this.adı.MinimumWidth = 6;
            this.adı.Name = "adı";
            // 
            // YapılıTarihi
            // 
            this.YapılıTarihi.HeaderText = "Yapılış Tarihi";
            this.YapılıTarihi.MinimumWidth = 6;
            this.YapılıTarihi.Name = "YapılıTarihi";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fiyat";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // sepet_boşaltma
            // 
            this.sepet_boşaltma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepet_boşaltma.Location = new System.Drawing.Point(204, 518);
            this.sepet_boşaltma.Name = "sepet_boşaltma";
            this.sepet_boşaltma.Size = new System.Drawing.Size(195, 78);
            this.sepet_boşaltma.TabIndex = 2;
            this.sepet_boşaltma.Text = "Sepetimi Boşalt";
            this.sepet_boşaltma.UseVisualStyleBackColor = true;
            this.sepet_boşaltma.Click += new System.EventHandler(this.button2_Click);
            // 
            // Toplam_fiyat
            // 
            this.Toplam_fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Toplam_fiyat.Location = new System.Drawing.Point(499, 418);
            this.Toplam_fiyat.Multiline = true;
            this.Toplam_fiyat.Name = "Toplam_fiyat";
            this.Toplam_fiyat.Size = new System.Drawing.Size(112, 43);
            this.Toplam_fiyat.TabIndex = 1;
            this.Toplam_fiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Toplam_fiyat.TextChanged += new System.EventHandler(this.Toplam_fiyat_TextChanged);
            // 
            // ürün_sayısı
            // 
            this.ürün_sayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürün_sayısı.Location = new System.Drawing.Point(499, 327);
            this.ürün_sayısı.Multiline = true;
            this.ürün_sayısı.Name = "ürün_sayısı";
            this.ürün_sayısı.Size = new System.Drawing.Size(112, 43);
            this.ürün_sayısı.TabIndex = 0;
            this.ürün_sayısı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(289, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 43);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ürün Sayısı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(289, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 43);
            this.label2.TabIndex = 20;
            this.label2.Text = "Toplam Fiyat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1033, 662);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ürün_sayısı);
            this.Controls.Add(this.Toplam_fiyat);
            this.Controls.Add(this.sepet_boşaltma);
            this.Controls.Add(this.sepet_listesi);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "sepet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sepet";
            this.Load += new System.EventHandler(this.sepet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sepet_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView sepet_listesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn adı;
        private System.Windows.Forms.DataGridViewTextBoxColumn YapılıTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button sepet_boşaltma;
        private System.Windows.Forms.TextBox Toplam_fiyat;
        private System.Windows.Forms.TextBox ürün_sayısı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}