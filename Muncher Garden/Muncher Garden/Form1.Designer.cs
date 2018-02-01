namespace Muncher_Garden
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.row1 = new Muncher_Garden.Row();
            this.row2 = new Muncher_Garden.Row();
            this.row3 = new Muncher_Garden.Row();
            this.row4 = new Muncher_Garden.Row();
            this.row5 = new Muncher_Garden.Row();
            this.counter = new System.Windows.Forms.Label();
            this.garden = new System.Windows.Forms.GroupBox();
            this.shop = new System.Windows.Forms.GroupBox();
            this.sumtextXD = new System.Windows.Forms.Label();
            this.selrow = new System.Windows.Forms.NumericUpDown();
            this.selcol = new System.Windows.Forms.NumericUpDown();
            this.bp = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upgradeclickme = new System.Windows.Forms.PictureBox();
            this.clickme = new System.Windows.Forms.PictureBox();
            this.garden.SuspendLayout();
            this.shop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selcol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgradeclickme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickme)).BeginInit();
            this.SuspendLayout();
            // 
            // row1
            // 
            this.row1.Location = new System.Drawing.Point(15, 13);
            this.row1.Name = "row1";
            this.row1.Size = new System.Drawing.Size(531, 100);
            this.row1.TabIndex = 0;
            // 
            // row2
            // 
            this.row2.Location = new System.Drawing.Point(15, 119);
            this.row2.Name = "row2";
            this.row2.Size = new System.Drawing.Size(531, 100);
            this.row2.TabIndex = 1;
            // 
            // row3
            // 
            this.row3.Location = new System.Drawing.Point(15, 225);
            this.row3.Name = "row3";
            this.row3.Size = new System.Drawing.Size(531, 100);
            this.row3.TabIndex = 2;
            // 
            // row4
            // 
            this.row4.Location = new System.Drawing.Point(15, 331);
            this.row4.Name = "row4";
            this.row4.Size = new System.Drawing.Size(531, 100);
            this.row4.TabIndex = 3;
            // 
            // row5
            // 
            this.row5.Location = new System.Drawing.Point(15, 437);
            this.row5.Name = "row5";
            this.row5.Size = new System.Drawing.Size(531, 100);
            this.row5.TabIndex = 4;
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Location = new System.Drawing.Point(651, 66);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(43, 13);
            this.counter.TabIndex = 5;
            this.counter.Text = "Buds: 0";
            // 
            // garden
            // 
            this.garden.BackColor = System.Drawing.SystemColors.Control;
            this.garden.Controls.Add(this.row5);
            this.garden.Controls.Add(this.row4);
            this.garden.Controls.Add(this.row3);
            this.garden.Controls.Add(this.row2);
            this.garden.Controls.Add(this.row1);
            this.garden.Location = new System.Drawing.Point(24, 16);
            this.garden.Name = "garden";
            this.garden.Size = new System.Drawing.Size(554, 542);
            this.garden.TabIndex = 7;
            this.garden.TabStop = false;
            this.garden.Text = " ";
            // 
            // shop
            // 
            this.shop.Controls.Add(this.up);
            this.shop.Controls.Add(this.bp);
            this.shop.Controls.Add(this.pictureBox1);
            this.shop.Controls.Add(this.upgradeclickme);
            this.shop.Controls.Add(this.sumtextXD);
            this.shop.Controls.Add(this.selrow);
            this.shop.Controls.Add(this.selcol);
            this.shop.Location = new System.Drawing.Point(650, 159);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(289, 373);
            this.shop.TabIndex = 8;
            this.shop.TabStop = false;
            this.shop.Text = "shop";
            // 
            // sumtextXD
            // 
            this.sumtextXD.AutoSize = true;
            this.sumtextXD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumtextXD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sumtextXD.Location = new System.Drawing.Point(59, 216);
            this.sumtextXD.Name = "sumtextXD";
            this.sumtextXD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sumtextXD.Size = new System.Drawing.Size(61, 40);
            this.sumtextXD.TabIndex = 2;
            this.sumtextXD.Text = "Row:\r\nCollum:";
            this.sumtextXD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // selrow
            // 
            this.selrow.Location = new System.Drawing.Point(126, 211);
            this.selrow.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.selrow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selrow.Name = "selrow";
            this.selrow.Size = new System.Drawing.Size(120, 20);
            this.selrow.TabIndex = 1;
            this.selrow.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // selcol
            // 
            this.selcol.Location = new System.Drawing.Point(126, 237);
            this.selcol.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.selcol.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selcol.Name = "selcol";
            this.selcol.Size = new System.Drawing.Size(120, 20);
            this.selcol.TabIndex = 0;
            this.selcol.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bp
            // 
            this.bp.AutoSize = true;
            this.bp.Location = new System.Drawing.Point(25, 185);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(19, 13);
            this.bp.TabIndex = 11;
            this.bp.Text = "50";
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Location = new System.Drawing.Point(19, 259);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(25, 13);
            this.up.TabIndex = 12;
            this.up.Text = "100";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Muncher_Garden.Resource1.buy;
            this.pictureBox1.Location = new System.Drawing.Point(13, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // upgradeclickme
            // 
            this.upgradeclickme.Image = global::Muncher_Garden.Resource1.upgrade;
            this.upgradeclickme.Location = new System.Drawing.Point(13, 216);
            this.upgradeclickme.Name = "upgradeclickme";
            this.upgradeclickme.Size = new System.Drawing.Size(40, 40);
            this.upgradeclickme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upgradeclickme.TabIndex = 9;
            this.upgradeclickme.TabStop = false;
            this.upgradeclickme.Click += new System.EventHandler(this.upgradeclickme_Click);
            // 
            // clickme
            // 
            this.clickme.Image = global::Muncher_Garden.Resource1.n;
            this.clickme.Location = new System.Drawing.Point(415, 558);
            this.clickme.Name = "clickme";
            this.clickme.Size = new System.Drawing.Size(80, 80);
            this.clickme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clickme.TabIndex = 6;
            this.clickme.TabStop = false;
            this.clickme.Click += new System.EventHandler(this.clickme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.shop);
            this.Controls.Add(this.garden);
            this.Controls.Add(this.clickme);
            this.Controls.Add(this.counter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Muncher Garden";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.garden.ResumeLayout(false);
            this.shop.ResumeLayout(false);
            this.shop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selcol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upgradeclickme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clickme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Row row1;
        public Row row2;
        public Row row3;
        public Row row4;
        public Row row5;
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.PictureBox clickme;
        private System.Windows.Forms.GroupBox shop;
        private System.Windows.Forms.NumericUpDown selrow;
        private System.Windows.Forms.NumericUpDown selcol;
        private System.Windows.Forms.Label sumtextXD;
        private System.Windows.Forms.PictureBox upgradeclickme;
        public System.Windows.Forms.GroupBox garden;
        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label bp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

