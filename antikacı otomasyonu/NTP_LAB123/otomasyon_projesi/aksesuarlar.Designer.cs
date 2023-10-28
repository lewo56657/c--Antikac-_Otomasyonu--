namespace proje2
{
    partial class aksesuarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aksesuarlar));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aksesuarfiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksesuarlarıFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Aksesuar_Listesi = new System.Windows.Forms.ListView();
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
            this.aksesuarfiltreleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 31);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aksesuarfiltreleToolStripMenuItem
            // 
            this.aksesuarfiltreleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksesuarlarıFiltreleToolStripMenuItem});
            this.aksesuarfiltreleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aksesuarfiltreleToolStripMenuItem.Name = "aksesuarfiltreleToolStripMenuItem";
            this.aksesuarfiltreleToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.aksesuarfiltreleToolStripMenuItem.Text = "filtrele";
            this.aksesuarfiltreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // aksesuarlarıFiltreleToolStripMenuItem
            // 
            this.aksesuarlarıFiltreleToolStripMenuItem.Name = "aksesuarlarıFiltreleToolStripMenuItem";
            this.aksesuarlarıFiltreleToolStripMenuItem.Size = new System.Drawing.Size(250, 28);
            this.aksesuarlarıFiltreleToolStripMenuItem.Text = "Aksesuarları filtrele";
            // 
            // Aksesuar_Listesi
            // 
            this.Aksesuar_Listesi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Aksesuar_Listesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.Aksesuar_Listesi.HideSelection = false;
            this.Aksesuar_Listesi.Location = new System.Drawing.Point(0, 218);
            this.Aksesuar_Listesi.Name = "Aksesuar_Listesi";
            this.Aksesuar_Listesi.Size = new System.Drawing.Size(431, 163);
            this.Aksesuar_Listesi.TabIndex = 16;
            this.Aksesuar_Listesi.UseCompatibleStateImageBehavior = false;
            this.Aksesuar_Listesi.View = System.Windows.Forms.View.Details;
            this.Aksesuar_Listesi.SelectedIndexChanged += new System.EventHandler(this.Aksesuar_Listesi_SelectedIndexChanged);
            this.Aksesuar_Listesi.DoubleClick += new System.EventHandler(this.Aksesuar_Listesi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ıd";
            this.columnHeader1.Width = 63;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 146;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapılış Tarihi";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyatı";
            this.columnHeader4.Width = 131;
            // 
            // aksesuarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 678);
            this.Controls.Add(this.Aksesuar_Listesi);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "aksesuarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "aksesuarlar";
            this.Load += new System.EventHandler(this.aksesuarlar_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aksesuarfiltreleToolStripMenuItem;
        public System.Windows.Forms.ListView Aksesuar_Listesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ToolStripMenuItem aksesuarlarıFiltreleToolStripMenuItem;
    }
}