namespace proje2
{
    partial class heykeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(heykeller));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heykelfiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heykelleriFiltreleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heykel_listesi = new System.Windows.Forms.ListView();
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
            this.heykelfiltreleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 31);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heykelfiltreleToolStripMenuItem
            // 
            this.heykelfiltreleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heykelleriFiltreleToolStripMenuItem});
            this.heykelfiltreleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.heykelfiltreleToolStripMenuItem.Name = "heykelfiltreleToolStripMenuItem";
            this.heykelfiltreleToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.heykelfiltreleToolStripMenuItem.Text = "filtrele";
            this.heykelfiltreleToolStripMenuItem.Click += new System.EventHandler(this.filtreleToolStripMenuItem_Click);
            // 
            // heykelleriFiltreleToolStripMenuItem
            // 
            this.heykelleriFiltreleToolStripMenuItem.Name = "heykelleriFiltreleToolStripMenuItem";
            this.heykelleriFiltreleToolStripMenuItem.Size = new System.Drawing.Size(226, 28);
            this.heykelleriFiltreleToolStripMenuItem.Text = "Heykelleri Filtrele";
            // 
            // heykel_listesi
            // 
            this.heykel_listesi.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.heykel_listesi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.heykel_listesi.HideSelection = false;
            this.heykel_listesi.Location = new System.Drawing.Point(0, 391);
            this.heykel_listesi.Name = "heykel_listesi";
            this.heykel_listesi.Size = new System.Drawing.Size(424, 163);
            this.heykel_listesi.TabIndex = 16;
            this.heykel_listesi.UseCompatibleStateImageBehavior = false;
            this.heykel_listesi.View = System.Windows.Forms.View.Details;
            this.heykel_listesi.SelectedIndexChanged += new System.EventHandler(this.heykel_listesi_SelectedIndexChanged);
            this.heykel_listesi.DoubleClick += new System.EventHandler(this.heykel_listesi_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ıd";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yapılış Tarihi";
            this.columnHeader3.Width = 173;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyatı";
            this.columnHeader4.Width = 131;
            // 
            // heykeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 622);
            this.Controls.Add(this.heykel_listesi);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "heykeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.heykeller_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heykelfiltreleToolStripMenuItem;
        public System.Windows.Forms.ListView heykel_listesi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ToolStripMenuItem heykelleriFiltreleToolStripMenuItem;
    }
}