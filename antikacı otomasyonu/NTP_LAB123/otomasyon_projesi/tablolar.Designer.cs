namespace proje2
{
    partial class tablolar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tablolar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablofiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablolarıFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tablo_Listesi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataSet11 = new proje2.DataSet1();
            this.dataSet12 = new proje2.DataSet1();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablofiltreleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 31);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablofiltreleToolStripMenuItem
            // 
            this.tablofiltreleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablolarıFiltreleToolStripMenuItem});
            this.tablofiltreleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tablofiltreleToolStripMenuItem.Name = "tablofiltreleToolStripMenuItem";
            this.tablofiltreleToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.tablofiltreleToolStripMenuItem.Text = "filtrele";
            this.tablofiltreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // tablolarıFiltreleToolStripMenuItem
            // 
            this.tablolarıFiltreleToolStripMenuItem.Name = "tablolarıFiltreleToolStripMenuItem";
            this.tablolarıFiltreleToolStripMenuItem.Size = new System.Drawing.Size(213, 28);
            this.tablolarıFiltreleToolStripMenuItem.Text = "Tabloları Filtrele";
            // 
            // Tablo_Listesi
            // 
            this.Tablo_Listesi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Tablo_Listesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Tablo_Listesi.HideSelection = false;
            this.Tablo_Listesi.Location = new System.Drawing.Point(65, 198);
            this.Tablo_Listesi.Name = "Tablo_Listesi";
            this.Tablo_Listesi.Size = new System.Drawing.Size(456, 163);
            this.Tablo_Listesi.TabIndex = 15;
            this.Tablo_Listesi.UseCompatibleStateImageBehavior = false;
            this.Tablo_Listesi.View = System.Windows.Forms.View.Details;
            this.Tablo_Listesi.DoubleClick += new System.EventHandler(this.Tablo_Listesi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ıd";
            this.columnHeader1.Width = 66;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 170;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapılış Tarihi";
            this.columnHeader3.Width = 103;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyatı";
            this.columnHeader4.Width = 131;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 606);
            this.Controls.Add(this.Tablo_Listesi);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "tablolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tablolar";
            this.Load += new System.EventHandler(this.tablolar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablofiltreleToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ListView Tablo_Listesi;
        private DataSet1 dataSet11;
        private DataSet1 dataSet12;
        public System.Windows.Forms.ToolStripMenuItem tablolarıFiltreleToolStripMenuItem;
    }
}