namespace Online_Book_Store
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(883, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.cDToolStripMenuItem,
            this.magazineToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novelToolStripMenuItem,
            this.taleToolStripMenuItem});
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.bookToolStripMenuItem.Text = "Book";
            // 
            // novelToolStripMenuItem
            // 
            this.novelToolStripMenuItem.Name = "novelToolStripMenuItem";
            this.novelToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.novelToolStripMenuItem.Text = "Novel";
            this.novelToolStripMenuItem.Click += new System.EventHandler(this.novelToolStripMenuItem_Click);
            // 
            // taleToolStripMenuItem
            // 
            this.taleToolStripMenuItem.Name = "taleToolStripMenuItem";
            this.taleToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.taleToolStripMenuItem.Text = "Tale";
            this.taleToolStripMenuItem.Click += new System.EventHandler(this.taleToolStripMenuItem_Click);
            // 
            // cDToolStripMenuItem
            // 
            this.cDToolStripMenuItem.Name = "cDToolStripMenuItem";
            this.cDToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cDToolStripMenuItem.Text = "CD";
            this.cDToolStripMenuItem.Click += new System.EventHandler(this.cDToolStripMenuItem_Click);
            // 
            // magazineToolStripMenuItem
            // 
            this.magazineToolStripMenuItem.Name = "magazineToolStripMenuItem";
            this.magazineToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.magazineToolStripMenuItem.Text = "Magazine";
            this.magazineToolStripMenuItem.Click += new System.EventHandler(this.magazineToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.cDsToolStripMenuItem,
            this.magazinesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.viewToolStripMenuItem.Text = "view";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.booksToolStripMenuItem.Text = "Books";
            this.booksToolStripMenuItem.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // cDsToolStripMenuItem
            // 
            this.cDsToolStripMenuItem.Name = "cDsToolStripMenuItem";
            this.cDsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cDsToolStripMenuItem.Text = "CD\'s";
            this.cDsToolStripMenuItem.Click += new System.EventHandler(this.cDsToolStripMenuItem_Click);
            // 
            // magazinesToolStripMenuItem
            // 
            this.magazinesToolStripMenuItem.Name = "magazinesToolStripMenuItem";
            this.magazinesToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.magazinesToolStripMenuItem.Text = "Magazines";
            this.magazinesToolStripMenuItem.Click += new System.EventHandler(this.magazinesToolStripMenuItem_Click);
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwProducts.Location = new System.Drawing.Point(0, 248);
            this.dgwProducts.MultiSelect = false;
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.ReadOnly = true;
            this.dgwProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwProducts.Size = new System.Drawing.Size(883, 305);
            this.dgwProducts.TabIndex = 6;
            this.dgwProducts.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellContentDoubleClick);
            this.dgwProducts.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwProducts_CellMouseDown);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.dgwProducts);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Activated += new System.EventHandler(this.FormAdmin_Activated);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazinesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwProducts;
    }
}