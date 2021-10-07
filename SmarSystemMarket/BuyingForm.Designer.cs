namespace SmarSystemMarket
{
    partial class BuyingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyingForm));
            this.button_continue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_ok = new System.Windows.Forms.Button();
            this.totla_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.price_txt = new System.Windows.Forms.TextBox();
            this.prod_name_txt = new System.Windows.Forms.TextBox();
            this.bar_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_back_cus = new System.Windows.Forms.Button();
            this.back_button_mnahel = new System.Windows.Forms.Button();
            this.button_cart = new System.Windows.Forms.Button();
            this.prod_pic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // button_continue
            // 
            this.button_continue.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_continue.Location = new System.Drawing.Point(326, 269);
            this.button_continue.Name = "button_continue";
            this.button_continue.Size = new System.Drawing.Size(320, 144);
            this.button_continue.TabIndex = 20;
            this.button_continue.Text = "&Continue";
            this.button_continue.UseVisualStyleBackColor = true;
            this.button_continue.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_ok);
            this.panel2.Controls.Add(this.totla_txt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.qty_txt);
            this.panel2.Controls.Add(this.price_txt);
            this.panel2.Controls.Add(this.prod_name_txt);
            this.panel2.Controls.Add(this.bar_txt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(27, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 58);
            this.panel2.TabIndex = 18;
            // 
            // button_ok
            // 
            this.button_ok.Font = new System.Drawing.Font("Script MT Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Location = new System.Drawing.Point(751, 16);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(38, 37);
            this.button_ok.TabIndex = 23;
            this.button_ok.Text = "&Ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button3_Click);
            // 
            // totla_txt
            // 
            this.totla_txt.Location = new System.Drawing.Point(798, 25);
            this.totla_txt.Name = "totla_txt";
            this.totla_txt.Size = new System.Drawing.Size(80, 20);
            this.totla_txt.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(667, 25);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(72, 20);
            this.qty_txt.TabIndex = 2;
            this.qty_txt.Text = "1";
            // 
            // price_txt
            // 
            this.price_txt.Location = new System.Drawing.Point(562, 25);
            this.price_txt.Name = "price_txt";
            this.price_txt.Size = new System.Drawing.Size(81, 20);
            this.price_txt.TabIndex = 3;
            // 
            // prod_name_txt
            // 
            this.prod_name_txt.Location = new System.Drawing.Point(342, 26);
            this.prod_name_txt.Name = "prod_name_txt";
            this.prod_name_txt.Size = new System.Drawing.Size(196, 20);
            this.prod_name_txt.TabIndex = 8;
            // 
            // bar_txt
            // 
            this.bar_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bar_txt.Location = new System.Drawing.Point(15, 26);
            this.bar_txt.Name = "bar_txt";
            this.bar_txt.Size = new System.Drawing.Size(277, 20);
            this.bar_txt.TabIndex = 0;
            this.bar_txt.Text = "0";
            this.bar_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(565, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BarCode";
            // 
            // button_back_cus
            // 
            this.button_back_cus.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_cus.Location = new System.Drawing.Point(25, 81);
            this.button_back_cus.Name = "button_back_cus";
            this.button_back_cus.Size = new System.Drawing.Size(295, 182);
            this.button_back_cus.TabIndex = 21;
            this.button_back_cus.Text = "&Back";
            this.button_back_cus.UseVisualStyleBackColor = true;
            this.button_back_cus.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_button_mnahel
            // 
            this.back_button_mnahel.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button_mnahel.Location = new System.Drawing.Point(25, 81);
            this.back_button_mnahel.Name = "back_button_mnahel";
            this.back_button_mnahel.Size = new System.Drawing.Size(293, 182);
            this.back_button_mnahel.TabIndex = 22;
            this.back_button_mnahel.Text = "&Back";
            this.back_button_mnahel.UseVisualStyleBackColor = true;
            this.back_button_mnahel.Visible = false;
            this.back_button_mnahel.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_cart
            // 
            this.button_cart.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cart.Location = new System.Drawing.Point(652, 81);
            this.button_cart.Name = "button_cart";
            this.button_cart.Size = new System.Drawing.Size(295, 182);
            this.button_cart.TabIndex = 23;
            this.button_cart.Text = "&Cart";
            this.button_cart.UseVisualStyleBackColor = true;
            this.button_cart.Click += new System.EventHandler(this.button4_Click);
            // 
            // prod_pic
            // 
            this.prod_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prod_pic.Location = new System.Drawing.Point(326, 81);
            this.prod_pic.Name = "prod_pic";
            this.prod_pic.Size = new System.Drawing.Size(320, 182);
            this.prod_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prod_pic.TabIndex = 24;
            this.prod_pic.TabStop = false;
            // 
            // BuyingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.prod_pic);
            this.Controls.Add(this.button_cart);
            this.Controls.Add(this.back_button_mnahel);
            this.Controls.Add(this.button_back_cus);
            this.Controls.Add(this.button_continue);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyingForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BuyingForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prod_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button button_continue;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.TextBox totla_txt;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox qty_txt;
        public System.Windows.Forms.TextBox price_txt;
        internal System.Windows.Forms.TextBox prod_name_txt;
        internal System.Windows.Forms.TextBox bar_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_back_cus;
        public System.Windows.Forms.Button back_button_mnahel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cart;
        private System.Windows.Forms.PictureBox prod_pic;
    }
}