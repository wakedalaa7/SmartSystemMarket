namespace SmarSystemMarket
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.dataGridView_visa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cuntimue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add_visa = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_visa
            // 
            this.dataGridView_visa.AllowUserToAddRows = false;
            this.dataGridView_visa.AllowUserToDeleteRows = false;
            this.dataGridView_visa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_visa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_visa.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_visa.Name = "dataGridView_visa";
            this.dataGridView_visa.ReadOnly = true;
            this.dataGridView_visa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_visa.Size = new System.Drawing.Size(320, 146);
            this.dataGridView_visa.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView_visa);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 146);
            this.panel1.TabIndex = 11;
            // 
            // button_cuntimue
            // 
            this.button_cuntimue.BackColor = System.Drawing.Color.Transparent;
            this.button_cuntimue.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cuntimue.ForeColor = System.Drawing.Color.DarkRed;
            this.button_cuntimue.Location = new System.Drawing.Point(175, 249);
            this.button_cuntimue.Name = "button_cuntimue";
            this.button_cuntimue.Size = new System.Drawing.Size(156, 83);
            this.button_cuntimue.TabIndex = 48;
            this.button_cuntimue.Text = "&Countinue";
            this.button_cuntimue.UseVisualStyleBackColor = false;
            this.button_cuntimue.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 47);
            this.label1.TabIndex = 49;
            this.label1.Text = "Select Your Visa :";
            // 
            // button_add_visa
            // 
            this.button_add_visa.BackColor = System.Drawing.Color.Transparent;
            this.button_add_visa.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add_visa.ForeColor = System.Drawing.Color.DarkRed;
            this.button_add_visa.Location = new System.Drawing.Point(12, 249);
            this.button_add_visa.Name = "button_add_visa";
            this.button_add_visa.Size = new System.Drawing.Size(156, 83);
            this.button_add_visa.TabIndex = 50;
            this.button_add_visa.Text = "&Add another Visa";
            this.button_add_visa.UseVisualStyleBackColor = false;
            this.button_add_visa.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(12, 360);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(52, 54);
            this.button_back.TabIndex = 51;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button3_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(347, 426);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_add_visa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cuntimue);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_visa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView_visa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_cuntimue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_add_visa;
        public System.Windows.Forms.Button button_back;
    }
}