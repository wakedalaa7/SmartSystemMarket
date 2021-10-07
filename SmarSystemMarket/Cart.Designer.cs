namespace SmarSystemMarket
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.panel_cart = new System.Windows.Forms.Panel();
            this.label_cart = new System.Windows.Forms.Label();
            this.button_back_mnahel = new System.Windows.Forms.Button();
            this.button_back_cus = new System.Windows.Forms.Button();
            this.icon_pic = new System.Windows.Forms.PictureBox();
            this.label_storage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_save = new System.Windows.Forms.Button();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.label_edit = new System.Windows.Forms.Label();
            this.button_delete_cart = new System.Windows.Forms.Button();
            this.button_pay = new System.Windows.Forms.Button();
            this.button_delete_storage = new System.Windows.Forms.Button();
            this.panel_cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pic)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_cart
            // 
            this.panel_cart.BackColor = System.Drawing.Color.SteelBlue;
            this.panel_cart.Controls.Add(this.label_cart);
            this.panel_cart.Controls.Add(this.button_back_mnahel);
            this.panel_cart.Controls.Add(this.button_back_cus);
            this.panel_cart.Controls.Add(this.icon_pic);
            this.panel_cart.Controls.Add(this.label_storage);
            this.panel_cart.Location = new System.Drawing.Point(15, 2);
            this.panel_cart.Name = "panel_cart";
            this.panel_cart.Size = new System.Drawing.Size(1169, 57);
            this.panel_cart.TabIndex = 13;
            // 
            // label_cart
            // 
            this.label_cart.AutoSize = true;
            this.label_cart.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cart.ForeColor = System.Drawing.Color.White;
            this.label_cart.Location = new System.Drawing.Point(451, -2);
            this.label_cart.Name = "label_cart";
            this.label_cart.Size = new System.Drawing.Size(107, 60);
            this.label_cart.TabIndex = 21;
            this.label_cart.Text = "Cart";
            // 
            // button_back_mnahel
            // 
            this.button_back_mnahel.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button_back_mnahel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_mnahel.Location = new System.Drawing.Point(3, 2);
            this.button_back_mnahel.Name = "button_back_mnahel";
            this.button_back_mnahel.Size = new System.Drawing.Size(52, 54);
            this.button_back_mnahel.TabIndex = 20;
            this.button_back_mnahel.UseVisualStyleBackColor = true;
            this.button_back_mnahel.Visible = false;
            this.button_back_mnahel.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button_back_cus
            // 
            this.button_back_cus.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button_back_cus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_cus.Location = new System.Drawing.Point(3, 3);
            this.button_back_cus.Name = "button_back_cus";
            this.button_back_cus.Size = new System.Drawing.Size(52, 54);
            this.button_back_cus.TabIndex = 19;
            this.button_back_cus.UseVisualStyleBackColor = true;
            this.button_back_cus.Click += new System.EventHandler(this.button6_Click);
            // 
            // icon_pic
            // 
            this.icon_pic.BackgroundImage = global::SmarSystemMarket.Properties.Resources.starpics;
            this.icon_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.icon_pic.Location = new System.Drawing.Point(374, 0);
            this.icon_pic.Name = "icon_pic";
            this.icon_pic.Size = new System.Drawing.Size(57, 57);
            this.icon_pic.TabIndex = 2;
            this.icon_pic.TabStop = false;
            // 
            // label_storage
            // 
            this.label_storage.AutoSize = true;
            this.label_storage.Font = new System.Drawing.Font("Viner Hand ITC", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_storage.ForeColor = System.Drawing.Color.White;
            this.label_storage.Location = new System.Drawing.Point(437, -3);
            this.label_storage.Name = "label_storage";
            this.label_storage.Size = new System.Drawing.Size(142, 60);
            this.label_storage.TabIndex = 1;
            this.label_storage.Text = "storage";
            this.label_storage.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(18, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(843, 410);
            this.panel3.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 408);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Transparent;
            this.button_save.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_save.Location = new System.Drawing.Point(1100, 92);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(84, 55);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "&Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(994, 111);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(100, 20);
            this.qty_txt.TabIndex = 45;
            this.qty_txt.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label_edit
            // 
            this.label_edit.AutoSize = true;
            this.label_edit.BackColor = System.Drawing.Color.Transparent;
            this.label_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label_edit.Location = new System.Drawing.Point(865, 114);
            this.label_edit.Name = "label_edit";
            this.label_edit.Size = new System.Drawing.Size(125, 13);
            this.label_edit.TabIndex = 46;
            this.label_edit.Text = "Edit Qty Of Product :";
            // 
            // button_delete_cart
            // 
            this.button_delete_cart.BackColor = System.Drawing.Color.Transparent;
            this.button_delete_cart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_cart.ForeColor = System.Drawing.Color.DarkRed;
            this.button_delete_cart.Location = new System.Drawing.Point(868, 153);
            this.button_delete_cart.Name = "button_delete_cart";
            this.button_delete_cart.Size = new System.Drawing.Size(316, 83);
            this.button_delete_cart.TabIndex = 47;
            this.button_delete_cart.Text = "&Delete";
            this.button_delete_cart.UseVisualStyleBackColor = false;
            this.button_delete_cart.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_pay
            // 
            this.button_pay.Font = new System.Drawing.Font("Script MT Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pay.Location = new System.Drawing.Point(868, 255);
            this.button_pay.Name = "button_pay";
            this.button_pay.Size = new System.Drawing.Size(316, 187);
            this.button_pay.TabIndex = 48;
            this.button_pay.Text = "&Payment";
            this.button_pay.UseVisualStyleBackColor = true;
            this.button_pay.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_delete_storage
            // 
            this.button_delete_storage.BackColor = System.Drawing.Color.Transparent;
            this.button_delete_storage.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_storage.ForeColor = System.Drawing.Color.DarkRed;
            this.button_delete_storage.Location = new System.Drawing.Point(868, 153);
            this.button_delete_storage.Name = "button_delete_storage";
            this.button_delete_storage.Size = new System.Drawing.Size(316, 83);
            this.button_delete_storage.TabIndex = 49;
            this.button_delete_storage.Text = "&Delete";
            this.button_delete_storage.UseVisualStyleBackColor = false;
            this.button_delete_storage.Visible = false;
            this.button_delete_storage.Click += new System.EventHandler(this.button4_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 505);
            this.Controls.Add(this.button_delete_storage);
            this.Controls.Add(this.button_pay);
            this.Controls.Add(this.button_delete_cart);
            this.Controls.Add(this.label_edit);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_cart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Cart_Load);
            this.panel_cart.ResumeLayout(false);
            this.panel_cart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_pic)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_cart;
        private System.Windows.Forms.PictureBox icon_pic;
        public System.Windows.Forms.Label label_storage;
        public System.Windows.Forms.Button button_back_cus;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button button_save;
        public System.Windows.Forms.TextBox qty_txt;
        public System.Windows.Forms.Label label_edit;
        public System.Windows.Forms.Button button_delete_cart;
        public System.Windows.Forms.Button button_pay;
        public System.Windows.Forms.Button button_back_mnahel;
        public System.Windows.Forms.Label label_cart;
        public System.Windows.Forms.Button button_delete_storage;
    }
}