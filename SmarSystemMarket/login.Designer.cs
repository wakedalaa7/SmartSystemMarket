namespace SmarSystemMarket
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.register_btn = new System.Windows.Forms.Button();
            this.loginpcbox2 = new System.Windows.Forms.PictureBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginpcbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.BackgroundImage = global::SmarSystemMarket.Properties.Resources.Register1;
            this.register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register_btn.Location = new System.Drawing.Point(8, 138);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(149, 49);
            this.register_btn.TabIndex = 0;
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // loginpcbox2
            // 
            this.loginpcbox2.Image = global::SmarSystemMarket.Properties.Resources.lock_icon;
            this.loginpcbox2.Location = new System.Drawing.Point(8, 85);
            this.loginpcbox2.Name = "loginpcbox2";
            this.loginpcbox2.Size = new System.Drawing.Size(54, 39);
            this.loginpcbox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginpcbox2.TabIndex = 3;
            this.loginpcbox2.TabStop = false;
            // 
            // loginlabel
            // 
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginlabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginlabel.Location = new System.Drawing.Point(2, 43);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(302, 39);
            this.loginlabel.TabIndex = 5;
            this.loginlabel.Text = "Enter Your ID";
            this.loginlabel.Click += new System.EventHandler(this.loginlabel_Click);
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.Transparent;
            this.start_btn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.start_btn.Image = global::SmarSystemMarket.Properties.Resources.rayt;
            this.start_btn.Location = new System.Drawing.Point(209, 126);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(95, 70);
            this.start_btn.TabIndex = 6;
            this.start_btn.Text = " Start";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            this.start_btn.MouseLeave += new System.EventHandler(this.start_btn_MouseLeave);
            this.start_btn.MouseHover += new System.EventHandler(this.start_btn_MouseHover);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(83, 94);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(196, 20);
            this.txtId.TabIndex = 9;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(308, 214);
            this.ControlBox = false;
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.loginpcbox2);
            this.Controls.Add(this.register_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginpcbox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.PictureBox loginpcbox2;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button start_btn;
        internal System.Windows.Forms.TextBox txtId;
    }
}

