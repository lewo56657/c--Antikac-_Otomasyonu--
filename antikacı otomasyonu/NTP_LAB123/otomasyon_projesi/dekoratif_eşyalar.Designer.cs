namespace proje2
{
    partial class dekoratif_eşyalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dekoratif_eşyalar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dekoratiffiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dekoratifEşyalaruıFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dek_eşya_listesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dekoratiffiltreleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dekoratiffiltreleToolStripMenuItem
            // 
            this.dekoratiffiltreleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dekoratifEşyalaruıFiltreleToolStripMenuItem});
            this.dekoratiffiltreleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dekoratiffiltreleToolStripMenuItem.Name = "dekoratiffiltreleToolStripMenuItem";
            this.dekoratiffiltreleToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.dekoratiffiltreleToolStripMenuItem.Text = "filtrele";
            this.dekoratiffiltreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // dekoratifEşyalaruıFiltreleToolStripMenuItem
            // 
            this.dekoratifEşyalaruıFiltreleToolStripMenuItem.Name = "dekoratifEşyalaruıFiltreleToolStripMenuItem";
            this.dekoratifEşyalaruıFiltreleToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.dekoratifEşyalaruıFiltreleToolStripMenuItem.Text = "Dekoratif Eşyaları Filtrele";
            // 
            // dek_eşya_listesi
            // 
            this.dek_eşya_listesi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dek_eşya_listesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dek_eşya_listesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.dek_eşya_listesi.FullRowSelect = true;
            this.dek_eşya_listesi.HideSelection = false;
            this.dek_eşya_listesi.Location = new System.Drawing.Point(0, 422);
            this.dek_eşya_listesi.Name = "dek_eşya_listesi";
            this.dek_eşya_listesi.Size = new System.Drawing.Size(483, 229);
            this.dek_eşya_listesi.TabIndex = 1;
            this.dek_eşya_listesi.UseCompatibleStateImageBehavior = false;
            this.dek_eşya_listesi.View = System.Windows.Forms.View.Details;
            this.dek_eşya_listesi.SelectedIndexChanged += new System.EventHandler(this.dek_eşya_listesi_SelectedIndexChanged);
            this.dek_eşya_listesi.DoubleClick += new System.EventHandler(this.dek_eşya_listesi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ıd";
            this.columnHeader1.Width = 56;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 182;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapılış Tarihi";
            this.columnHeader3.Width = 136;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyatı";
            this.columnHeader4.Width = 131;
            // 
            // dekoratif_eşyalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 680);
            this.Controls.Add(this.dek_eşya_listesi);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "dekoratif_eşyalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.dekoratif_eşyalar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dekoratiffiltreleToolStripMenuItem;
        public System.Windows.Forms.ListView dek_eşya_listesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ToolStripMenuItem dekoratifEşyalaruıFiltreleToolStripMenuItem;
    }
}