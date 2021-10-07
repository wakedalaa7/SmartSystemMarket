namespace SmarSystemMarket
{
    partial class visa_card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visa_card));
            this.master_card = new System.Windows.Forms.CheckBox();
            this.visa = new System.Windows.Forms.CheckBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_back_regstir = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.txt_visa_number = new System.Windows.Forms.TextBox();
            this.txt_sec = new System.Windows.Forms.TextBox();
            this.button_payment = new System.Windows.Forms.Button();
            this.button_back_payment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // master_card
            // 
            this.master_card.BackgroundImage = global::SmarSystemMarket.Properties.Resources.הורדה;
            this.master_card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.master_card.Location = new System.Drawing.Point(370, 115);
            this.master_card.Name = "master_card";
            this.master_card.Size = new System.Drawing.Size(85, 39);
            this.master_card.TabIndex = 1;
            this.master_card.UseVisualStyleBackColor = true;
            this.master_card.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // visa
            // 
            this.visa.BackgroundImage = global::SmarSystemMarket.Properties.Resources._1280px_Old_Visa_Logo_svg;
            this.visa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.visa.Location = new System.Drawing.Point(461, 115);
            this.visa.Name = "visa";
            this.visa.Size = new System.Drawing.Size(89, 39);
            this.visa.TabIndex = 2;
            this.visa.UseVisualStyleBackColor = true;
            this.visa.CheckedChanged += new System.EventHandler(this.visa_CheckedChanged);
            // 
            // loginlabel
            // 
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginlabel.Location = new System.Drawing.Point(92, 9);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(499, 50);
            this.loginlabel.TabIndex = 6;
            this.loginlabel.Text = "Insert your card information";
            this.loginlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Card number :  ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Card security code : ";
            // 
            // button_back_regstir
            // 
            this.button_back_regstir.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button_back_regstir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_regstir.Location = new System.Drawing.Point(1, 160);
            this.button_back_regstir.Name = "button_back_regstir";
            this.button_back_regstir.Size = new System.Drawing.Size(52, 54);
            this.button_back_regstir.TabIndex = 18;
            this.button_back_regstir.UseVisualStyleBackColor = true;
            this.button_back_regstir.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_login
            // 
            this.button_login.BackgroundImage = global::SmarSystemMarket.Properties.Resources.starpics;
            this.button_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_login.Location = new System.Drawing.Point(487, 160);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(63, 54);
            this.button_login.TabIndex = 19;
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_visa_number
            // 
            this.txt_visa_number.Location = new System.Drawing.Point(248, 77);
            this.txt_visa_number.Name = "txt_visa_number";
            this.txt_visa_number.Size = new System.Drawing.Size(302, 20);
            this.txt_visa_number.TabIndex = 47;
            // 
            // txt_sec
            // 
            this.txt_sec.Location = new System.Drawing.Point(232, 124);
            this.txt_sec.Name = "txt_sec";
            this.txt_sec.Size = new System.Drawing.Size(132, 20);
            this.txt_sec.TabIndex = 48;
            // 
            // button_payment
            // 
            this.button_payment.BackgroundImage = global::SmarSystemMarket.Properties.Resources.starpics;
            this.button_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_payment.Location = new System.Drawing.Point(487, 160);
            this.button_payment.Name = "button_payment";
            this.button_payment.Size = new System.Drawing.Size(63, 54);
            this.button_payment.TabIndex = 49;
            this.button_payment.UseVisualStyleBackColor = true;
            this.button_payment.Visible = false;
            this.button_payment.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_back_payment
            // 
            this.button_back_payment.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button_back_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back_payment.Location = new System.Drawing.Point(1, 160);
            this.button_back_payment.Name = "button_back_payment";
            this.button_back_payment.Size = new System.Drawing.Size(52, 54);
            this.button_back_payment.TabIndex = 50;
            this.button_back_payment.UseVisualStyleBackColor = true;
            this.button_back_payment.Click += new System.EventHandler(this.button4_Click);
            // 
            // visa_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(552, 215);
            this.ControlBox = false;
            this.Controls.Add(this.button_back_payment);
            this.Controls.Add(this.button_payment);
            this.Controls.Add(this.txt_sec);
            this.Controls.Add(this.txt_visa_number);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_back_regstir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.visa);
            this.Controls.Add(this.master_card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "visa_card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "visa_card";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.visa_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox master_card;
        private System.Windows.Forms.CheckBox visa;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button_back_regstir;
        public System.Windows.Forms.Button button_login;
        internal System.Windows.Forms.TextBox txt_visa_number;
        internal System.Windows.Forms.TextBox txt_sec;
        public System.Windows.Forms.Button button_payment;
        public System.Windows.Forms.Button button_back_payment;
    }
}