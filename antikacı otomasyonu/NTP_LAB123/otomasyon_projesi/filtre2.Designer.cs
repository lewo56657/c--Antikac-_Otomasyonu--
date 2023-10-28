namespace proje2
{
    partial class filtre2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filtre2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fiyat_aralık_barı = new System.Windows.Forms.TrackBar();
            this.tarih_aralık_barı = new System.Windows.Forms.TrackBar();
            this.Fiyat_Aralığı = new System.Windows.Forms.TextBox();
            this.Tarih_Aralığı = new System.Windows.Forms.TextBox();
            this.filtreleme_butonu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fiyat_aralık_barı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih_aralık_barı)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(261, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiyat Aralığı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(261, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yapılış Tarihi";
            // 
            // fiyat_aralık_barı
            // 
            this.fiyat_aralık_barı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.fiyat_aralık_barı.Location = new System.Drawing.Point(565, 59);
            this.fiyat_aralık_barı.Maximum = 2000;
            this.fiyat_aralık_barı.Name = "fiyat_aralık_barı";
            this.fiyat_aralık_barı.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.fiyat_aralık_barı.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fiyat_aralık_barı.Size = new System.Drawing.Size(56, 119);
            this.fiyat_aralık_barı.TabIndex = 0;
            this.fiyat_aralık_barı.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.fiyat_aralık_barı.Scroll += new System.EventHandler(this.fiyat_aralık_barı_Scroll);
            // 
            // tarih_aralık_barı
            // 
            this.tarih_aralık_barı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.tarih_aralık_barı.Location = new System.Drawing.Point(565, 257);
            this.tarih_aralık_barı.Maximum = 21;
            this.tarih_aralık_barı.Name = "tarih_aralık_barı";
            this.tarih_aralık_barı.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tarih_aralık_barı.Size = new System.Drawing.Size(56, 119);
            this.tarih_aralık_barı.TabIndex = 1;
            this.tarih_aralık_barı.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tarih_aralık_barı.Scroll += new System.EventHandler(this.tarih_aralık_barı_Scroll);
            // 
            // Fiyat_Aralığı
            // 
            this.Fiyat_Aralığı.Location = new System.Drawing.Point(428, 121);
            this.Fiyat_Aralığı.Multiline = true;
            this.Fiyat_Aralığı.Name = "Fiyat_Aralığı";
            this.Fiyat_Aralığı.Size = new System.Drawing.Size(100, 22);
            this.Fiyat_Aralığı.TabIndex = 4;
            // 
            // Tarih_Aralığı
            // 
            this.Tarih_Aralığı.Location = new System.Drawing.Point(428, 316);
            this.Tarih_Aralığı.Multiline = true;
            this.Tarih_Aralığı.Name = "Tarih_Aralığı";
            this.Tarih_Aralığı.Size = new System.Drawing.Size(100, 22);
            this.Tarih_Aralığı.TabIndex = 5;
            // 
            // filtreleme_butonu
            // 
            this.filtreleme_butonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.filtreleme_butonu.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.filtreleme_butonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreleme_butonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtreleme_butonu.Location = new System.Drawing.Point(387, 405);
            this.filtreleme_butonu.Name = "filtreleme_butonu";
            this.filtreleme_butonu.Size = new System.Drawing.Size(141, 49);
            this.filtreleme_butonu.TabIndex = 2;
            this.filtreleme_butonu.Text = "Filtrele";
            this.filtreleme_butonu.UseVisualStyleBackColor = false;
            this.filtreleme_butonu.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtre2
            // 
            this.AcceptButton = this.filtreleme_butonu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 509);
            this.Controls.Add(this.filtreleme_butonu);
            this.Controls.Add(this.Tarih_Aralığı);
            this.Controls.Add(this.tarih_aralık_barı);
            this.Controls.Add(this.fiyat_aralık_barı);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fiyat_Aralığı);
            this.DoubleBuffered = true;
            this.Name = "filtre2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "filtre2";
            this.Load += new System.EventHandler(this.filtre2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiyat_aralık_barı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarih_aralık_barı)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar fiyat_aralık_barı;
        private System.Windows.Forms.TrackBar tarih_aralık_barı;
        private System.Windows.Forms.TextBox Fiyat_Aralığı;
        private System.Windows.Forms.TextBox Tarih_Aralığı;
        private System.Windows.Forms.Button filtreleme_butonu;
    }
}