namespace SmarSystemMarket
{
    partial class AddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.button_pic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.weight_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.company_txt = new System.Windows.Forms.TextBox();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.barcode_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_barcode = new System.Windows.Forms.Label();
            this.panel_add_produckt = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.chooseDatein = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTime = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.lable_expdate = new System.Windows.Forms.Label();
            this.chooseexpdate = new System.Windows.Forms.DateTimePicker();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_add_produckt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chooseexpdate);
            this.GroupBox1.Controls.Add(this.lable_expdate);
            this.GroupBox1.Controls.Add(this.button_pic);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Controls.Add(this.qty_txt);
            this.GroupBox1.Controls.Add(this.weight_txt);
            this.GroupBox1.Controls.Add(this.label9);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.price_txt);
            this.GroupBox1.Controls.Add(this.company_txt);
            this.GroupBox1.Controls.Add(this.name_txt);
            this.GroupBox1.Controls.Add(this.barcode_txt);
            this.GroupBox1.Controls.Add(this.label1);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.label_barcode);
            this.GroupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(5, 82);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(668, 159);
            this.GroupBox1.TabIndex = 20;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Information";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // button_pic
            // 
            this.button_pic.Location = new System.Drawing.Point(502, 130);
            this.button_pic.Name = "button_pic";
            this.button_pic.Size = new System.Drawing.Size(149, 23);
            this.button_pic.TabIndex = 49;
            this.button_pic.Text = ".  .  .";
            this.button_pic.UseVisualStyleBackColor = true;
            this.button_pic.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(486, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(375, 97);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(105, 21);
            this.qty_txt.TabIndex = 45;
            // 
            // weight_txt
            // 
            this.weight_txt.Location = new System.Drawing.Point(132, 97);
            this.weight_txt.Name = "weight_txt";
            this.weight_txt.Size = new System.Drawing.Size(128, 21);
            this.weight_txt.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Weight :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Enter Quantity :";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(375, 61);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(105, 21);
            this.price_txt.TabIndex = 36;
            // 
            // company_txt
            // 
            this.company_txt.Location = new System.Drawing.Point(132, 61);
            this.company_txt.Name = "company_txt";
            this.company_txt.Size = new System.Drawing.Size(128, 21);
            this.company_txt.TabIndex = 35;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(375, 26);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(105, 21);
            this.name_txt.TabIndex = 34;
            // 
            // barcode_txt
            // 
            this.barcode_txt.Location = new System.Drawing.Point(132, 26);
            this.barcode_txt.Name = "barcode_txt";
            this.barcode_txt.Size = new System.Drawing.Size(128, 21);
            this.barcode_txt.TabIndex = 33;
            this.barcode_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label3.Location = new System.Drawing.Point(271, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "ProductPrice :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "ProductName :";
            // 
            // label_barcode
            // 
            this.label_barcode.AutoSize = true;
            this.label_barcode.Location = new System.Drawing.Point(22, 34);
            this.label_barcode.Name = "label_barcode";
            this.label_barcode.Size = new System.Drawing.Size(63, 13);
            this.label_barcode.TabIndex = 20;
            this.label_barcode.Text = "Barcode :";
            // 
            // panel_add_produckt
            // 
            this.panel_add_produckt.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_add_produckt.Controls.Add(this.pictureBox2);
            this.panel_add_produckt.Controls.Add(this.lblTitle);
            this.panel_add_produckt.Location = new System.Drawing.Point(5, 22);
            this.panel_add_produckt.Name = "panel_add_produckt";
            this.panel_add_produckt.Size = new System.Drawing.Size(668, 54);
            this.panel_add_produckt.TabIndex = 21;
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
            this.lblTitle.Size = new System.Drawing.Size(119, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Add Product";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.chooseDatein);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.DateTime);
            this.GroupBox2.Controls.Add(this.button_cancel);
            this.GroupBox2.Controls.Add(this.button_save);
            this.GroupBox2.Location = new System.Drawing.Point(5, 262);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(668, 90);
            this.GroupBox2.TabIndex = 22;
            this.GroupBox2.TabStop = false;
            // 
            // chooseDatein
            // 
            this.chooseDatein.Enabled = false;
            this.chooseDatein.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chooseDatein.Location = new System.Drawing.Point(6, 15);
            this.chooseDatein.Name = "chooseDatein";
            this.chooseDatein.Size = new System.Drawing.Size(104, 20);
            this.chooseDatein.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(72, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 23);
            this.label5.TabIndex = 21;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateTime
            // 
            this.DateTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DateTime.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime.ForeColor = System.Drawing.Color.Black;
            this.DateTime.Location = new System.Drawing.Point(3, 16);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(239, 23);
            this.DateTime.TabIndex = 20;
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
            this.button_cancel.Size = new System.Drawing.Size(75, 63);
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
            this.button_save.Size = new System.Drawing.Size(75, 63);
            this.button_save.TabIndex = 15;
            this.button_save.Text = "&Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // lable_expdate
            // 
            this.lable_expdate.AutoSize = true;
            this.lable_expdate.Location = new System.Drawing.Point(159, 135);
            this.lable_expdate.Name = "lable_expdate";
            this.lable_expdate.Size = new System.Drawing.Size(66, 13);
            this.lable_expdate.TabIndex = 50;
            this.lable_expdate.Text = "Exp date :";
            // 
            // chooseexpdate
            // 
            this.chooseexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chooseexpdate.Location = new System.Drawing.Point(252, 129);
            this.chooseexpdate.Name = "chooseexpdate";
            this.chooseexpdate.Size = new System.Drawing.Size(138, 21);
            this.chooseexpdate.TabIndex = 51;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 375);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.panel_add_produckt);
            this.Controls.Add(this.GroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditProductInStock";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddEditProductInStock_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_add_produckt.ResumeLayout(false);
            this.panel_add_produckt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox price_txt;
        internal System.Windows.Forms.TextBox company_txt;
        internal System.Windows.Forms.TextBox name_txt;
        internal System.Windows.Forms.TextBox barcode_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_barcode;
        private System.Windows.Forms.Panel panel_add_produckt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.DateTimePicker chooseDatein;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DateTime;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_save;
        internal System.Windows.Forms.TextBox weight_txt;
        private System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox qty_txt;
        private System.Windows.Forms.Button button_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label lable_expdate;
        internal System.Windows.Forms.DateTimePicker chooseexpdate;
    }
}