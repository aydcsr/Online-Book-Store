namespace Online_Book_Store
{
    partial class FormCdUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCdUpdate));
            this.gbCd = new System.Windows.Forms.GroupBox();
            this.btnCdDelete = new System.Windows.Forms.Button();
            this.btnCdAdd = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tbSongType = new System.Windows.Forms.TextBox();
            this.rbCdVisibility = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCdPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCdSinger = new System.Windows.Forms.TextBox();
            this.tbCdName = new System.Windows.Forms.TextBox();
            this.tbCdSale = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbCd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCd
            // 
            this.gbCd.Controls.Add(this.btnCdDelete);
            this.gbCd.Controls.Add(this.btnCdAdd);
            this.gbCd.Controls.Add(this.label19);
            this.gbCd.Controls.Add(this.tbSongType);
            this.gbCd.Controls.Add(this.rbCdVisibility);
            this.gbCd.Controls.Add(this.label18);
            this.gbCd.Controls.Add(this.tbCdPrice);
            this.gbCd.Controls.Add(this.label14);
            this.gbCd.Controls.Add(this.label15);
            this.gbCd.Controls.Add(this.tbCdSinger);
            this.gbCd.Controls.Add(this.tbCdName);
            this.gbCd.Controls.Add(this.tbCdSale);
            this.gbCd.Controls.Add(this.label17);
            this.gbCd.Controls.Add(this.label16);
            this.gbCd.Location = new System.Drawing.Point(12, 25);
            this.gbCd.Name = "gbCd";
            this.gbCd.Size = new System.Drawing.Size(228, 282);
            this.gbCd.TabIndex = 63;
            this.gbCd.TabStop = false;
            this.gbCd.Text = "CD\'s";
            // 
            // btnCdDelete
            // 
            this.btnCdDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnCdDelete.FlatAppearance.BorderSize = 0;
            this.btnCdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCdDelete.ForeColor = System.Drawing.Color.White;
            this.btnCdDelete.Location = new System.Drawing.Point(20, 234);
            this.btnCdDelete.Name = "btnCdDelete";
            this.btnCdDelete.Size = new System.Drawing.Size(195, 31);
            this.btnCdDelete.TabIndex = 59;
            this.btnCdDelete.Text = "CD DELETE";
            this.btnCdDelete.UseVisualStyleBackColor = false;
            this.btnCdDelete.Click += new System.EventHandler(this.btnCdDelete_Click);
            // 
            // btnCdAdd
            // 
            this.btnCdAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnCdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCdAdd.FlatAppearance.BorderSize = 0;
            this.btnCdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCdAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCdAdd.ForeColor = System.Drawing.Color.White;
            this.btnCdAdd.Location = new System.Drawing.Point(20, 195);
            this.btnCdAdd.Name = "btnCdAdd";
            this.btnCdAdd.Size = new System.Drawing.Size(195, 33);
            this.btnCdAdd.TabIndex = 49;
            this.btnCdAdd.Text = "CD UPDATE";
            this.btnCdAdd.UseVisualStyleBackColor = false;
            this.btnCdAdd.Click += new System.EventHandler(this.btnCdAdd_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "visibility";
            // 
            // tbSongType
            // 
            this.tbSongType.Location = new System.Drawing.Point(115, 139);
            this.tbSongType.Name = "tbSongType";
            this.tbSongType.Size = new System.Drawing.Size(100, 20);
            this.tbSongType.TabIndex = 57;
            // 
            // rbCdVisibility
            // 
            this.rbCdVisibility.AutoSize = true;
            this.rbCdVisibility.Location = new System.Drawing.Point(115, 166);
            this.rbCdVisibility.Name = "rbCdVisibility";
            this.rbCdVisibility.Size = new System.Drawing.Size(39, 17);
            this.rbCdVisibility.TabIndex = 49;
            this.rbCdVisibility.TabStop = true;
            this.rbCdVisibility.Text = "On";
            this.rbCdVisibility.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 142);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Song Of Type";
            // 
            // tbCdPrice
            // 
            this.tbCdPrice.Location = new System.Drawing.Point(115, 84);
            this.tbCdPrice.Name = "tbCdPrice";
            this.tbCdPrice.Size = new System.Drawing.Size(100, 20);
            this.tbCdPrice.TabIndex = 49;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "CD Singer";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "CD Price";
            // 
            // tbCdSinger
            // 
            this.tbCdSinger.Location = new System.Drawing.Point(115, 32);
            this.tbCdSinger.Name = "tbCdSinger";
            this.tbCdSinger.Size = new System.Drawing.Size(100, 20);
            this.tbCdSinger.TabIndex = 55;
            // 
            // tbCdName
            // 
            this.tbCdName.Location = new System.Drawing.Point(115, 58);
            this.tbCdName.Name = "tbCdName";
            this.tbCdName.Size = new System.Drawing.Size(100, 20);
            this.tbCdName.TabIndex = 53;
            // 
            // tbCdSale
            // 
            this.tbCdSale.Location = new System.Drawing.Point(115, 110);
            this.tbCdSale.Name = "tbCdSale";
            this.tbCdSale.Size = new System.Drawing.Size(100, 20);
            this.tbCdSale.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "CD Sale";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 54;
            this.label16.Text = "CD Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, -102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 623);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // FormCdUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 418);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbCd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCdUpdate";
            this.Text = "FormCdUpdate";
            this.Load += new System.EventHandler(this.FormCdUpdate_Load);
            this.gbCd.ResumeLayout(false);
            this.gbCd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCd;
        private System.Windows.Forms.Button btnCdAdd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbSongType;
        private System.Windows.Forms.RadioButton rbCdVisibility;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCdPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbCdSinger;
        private System.Windows.Forms.TextBox tbCdName;
        private System.Windows.Forms.TextBox tbCdSale;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCdDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}