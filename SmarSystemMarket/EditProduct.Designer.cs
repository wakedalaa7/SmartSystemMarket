namespace SmarSystemMarket
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateTime = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel_editprod = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button_check = new System.Windows.Forms.Button();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.company_txt = new System.Windows.Forms.TextBox();
            this.prod_txt = new System.Windows.Forms.TextBox();
            this.barcode_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.panel_editprod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.DateTimePicker1);
            this.GroupBox2.Controls.Add(this.DateTime);
            this.GroupBox2.Controls.Add(this.button_cancel);
            this.GroupBox2.Controls.Add(this.button_save);
            this.GroupBox2.Location = new System.Drawing.Point(-3, 230);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(647, 63);
            this.GroupBox2.TabIndex = 19;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Enabled = false;
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(6, 15);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.DateTimePicker1.TabIndex = 18;
            // 
            // DateTime
            // 
            this.DateTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DateTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.ForeColor = System.Drawing.Color.Black;
            this.DateTime.Location = new System.Drawing.Point(72, 15);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(188, 23);
            this.DateTime.TabIndex = 17;
            this.DateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.PowderBlue;
            this.button_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button_cancel.Location = new System.Drawing.Point(562, 16);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 42);
            this.button_cancel.TabIndex = 16;
            this.button_cancel.Text = "&Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.PowderBlue;
            this.button_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button_save.Location = new System.Drawing.Point(481, 16);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 42);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "&Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_editprod
            // 
            this.panel_editprod.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_editprod.Controls.Add(this.pictureBox2);
            this.panel_editprod.Controls.Add(this.lblTitle);
            this.panel_editprod.Location = new System.Drawing.Point(-11, -8);
            this.panel_editprod.Name = "panel_editprod";
            this.panel_editprod.Size = new System.Drawing.Size(668, 54);
            this.panel_editprod.TabIndex = 18;
            this.panel_editprod.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(8, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 44);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(49, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Edit Product";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.button_check);
            this.GroupBox1.Controls.Add(this.qty_txt);
            this.GroupBox1.Controls.Add(this.price_txt);
            this.GroupBox1.Controls.Add(this.company_txt);
            this.GroupBox1.Controls.Add(this.prod_txt);
            this.GroupBox1.Controls.Add(this.barcode_txt);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(-3, 69);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(647, 142);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Information";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Script MT Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(536, 0);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(111, 142);
            this.button_check.TabIndex = 26;
            this.button_check.Text = "&Check";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button3_Click);
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(132, 92);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(128, 21);
            this.qty_txt.TabIndex = 4;
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(402, 56);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(128, 21);
            this.price_txt.TabIndex = 3;
            // 
            // company_txt
            // 
            this.company_txt.Location = new System.Drawing.Point(132, 61);
            this.company_txt.Name = "company_txt";
            this.company_txt.Size = new System.Drawing.Size(128, 21);
            this.company_txt.TabIndex = 2;
            // 
            // prod_txt
            // 
            this.prod_txt.Location = new System.Drawing.Point(402, 26);
            this.prod_txt.Name = "prod_txt";
            this.prod_txt.Size = new System.Drawing.Size(128, 21);
            this.prod_txt.TabIndex = 1;
            // 
            // barcode_txt
            // 
            this.barcode_txt.Location = new System.Drawing.Point(132, 26);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(128, 21);
            this.barcode_txt.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "QuantityInStock :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Company :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "ProductPrice :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ProductName :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Barcode :";
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 315);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.panel_editprod);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditProduct";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddEditProduct_Load);
            this.GroupBox2.ResumeLayout(false);
            this.panel_editprod.ResumeLayout(false);
            this.panel_editprod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel_editprod;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox qty_txt;
        internal System.Windows.Forms.TextBox price_txt;
        internal System.Windows.Forms.TextBox company_txt;
        internal System.Windows.Forms.TextBox prod_txt;
        internal System.Windows.Forms.TextBox barcode_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_check;
    }
}