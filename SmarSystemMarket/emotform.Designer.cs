namespace SmarSystemMarket
{
    partial class emotform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(emotform));
            this.loginlabel = new System.Windows.Forms.Label();
            this.loginpcbox2 = new System.Windows.Forms.PictureBox();
            this.start_btn_mnahel_cus = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.button_back_login = new System.Windows.Forms.Button();
            this.button_finish = new System.Windows.Forms.Button();
            this.button_back_payment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loginpcbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginlabel.Location = new System.Drawing.Point(-1, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(302, 84);
            this.loginlabel.TabIndex = 8;
            this.loginlabel.Text = "Enter The Code That Have Sended To Your Email :";
            // 
            // loginpcbox2
            // 
            this.loginpcbox2.Image = global::SmarSystemMarket.Properties.Resources.lock_icon;
            this.loginpcbox2.Location = new System.Drawing.Point(3, 111);
            this.loginpcbox2.Name = "loginpcbox2";
            this.loginpcbox2.Size = new System.Drawing.Size(54, 39);
            this.loginpcbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpcbox2.TabIndex = 6;
            this.loginpcbox2.TabStop = false;
            // 
            // start_btn_mnahel_cus
            // 
            this.start_btn_mnahel_cus.BackColor = System.Drawing.Color.Transparent;
            this.start_btn_mnahel_cus.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn_mnahel_cus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.start_btn_mnahel_cus.Image = global::SmarSystemMarket.Properties.Resources.rayt;
            this.start_btn_mnahel_cus.Location = new System.Drawing.Point(187, 83);
            this.start_btn_mnahel_cus.Name = "start_btn_mnahel_cus";
            this.start_btn_mnahel_cus.Size = new System.Drawing.Size(95, 70);
            this.start_btn_mnahel_cus.TabIndex = 9;
            this.start_btn_mnahel_cus.Text = " Start";
            this.start_btn_mnahel_cus.UseVisualStyleBackColor = false;
            this.start_btn_mnahel_cus.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(63, 123);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(118, 20);
            this.id_txt.TabIndex = 10;
            // 
            // button_back_login
            // 
            this.button_back_login.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_login.Location = new System.Drawing.Point(5, 192);
            this.button_back_login.Name = "button_back_login";
            this.button_back_login.Size = new System.Drawing.Size(150, 53);
            this.button_back_login.TabIndex = 24;
            this.button_back_login.Text = "&Back";
            this.button_back_login.UseVisualStyleBackColor = true;
            this.button_back_login.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_finish
            // 
            this.button_finish.BackColor = System.Drawing.Color.Transparent;
            this.button_finish.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_finish.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_finish.Image = global::SmarSystemMarket.Properties.Resources.rayt;
            this.button_finish.Location = new System.Drawing.Point(187, 83);
            this.button_finish.Name = "button_finish";
            this.button_finish.Size = new System.Drawing.Size(95, 70);
            this.button_finish.TabIndex = 25;
            this.button_finish.Text = " Start";
            this.button_finish.UseVisualStyleBackColor = false;
            this.button_finish.Visible = false;
            this.button_finish.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button_back_payment
            // 
            this.button_back_payment.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back_payment.Location = new System.Drawing.Point(3, 192);
            this.button_back_payment.Name = "button_back_payment";
            this.button_back_payment.Size = new System.Drawing.Size(150, 53);
            this.button_back_payment.TabIndex = 26;
            this.button_back_payment.Text = "&Back";
            this.button_back_payment.UseVisualStyleBackColor = true;
            this.button_back_payment.Visible = false;
            this.button_back_payment.Click += new System.EventHandler(this.button3_Click);
            // 
            // emotform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 257);
            this.ControlBox = false;
            this.Controls.Add(this.button_back_payment);
            this.Controls.Add(this.button_finish);
            this.Controls.Add(this.button_back_login);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.start_btn_mnahel_cus);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.loginpcbox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "emotform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.emotform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginpcbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.PictureBox loginpcbox2;
        public System.Windows.Forms.Button start_btn_mnahel_cus;
        private System.Windows.Forms.TextBox id_txt;
        public System.Windows.Forms.Button button_back_login;
        public System.Windows.Forms.Button button_finish;
        public System.Windows.Forms.Button button_back_payment;
    }
}