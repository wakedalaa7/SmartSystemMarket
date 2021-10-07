namespace SmarSystemMarket
{
    partial class ReportFilterMarket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportFilterMarket));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rbexpdate = new System.Windows.Forms.RadioButton();
            this.rbSorageIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_cancel);
            this.groupBox1.Controls.Add(this.button_load);
            this.groupBox1.Location = new System.Drawing.Point(56, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 87);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
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
            this.button_cancel.Location = new System.Drawing.Point(217, 14);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 63);
            this.button_cancel.TabIndex = 16;
            this.button_cancel.Text = "&Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_load
            // 
            this.button_load.BackColor = System.Drawing.Color.PowderBlue;
            this.button_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_load.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button_load.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic);
            this.button_load.Location = new System.Drawing.Point(136, 14);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(75, 63);
            this.button_load.TabIndex = 15;
            this.button_load.Text = "&Load Report";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.dateTimePicker2);
            this.GroupBox3.Controls.Add(this.DateTimePicker1);
            this.GroupBox3.Controls.Add(this.rbexpdate);
            this.GroupBox3.Controls.Add(this.rbSorageIn);
            this.GroupBox3.Controls.Add(this.label1);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(53, 112);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(305, 128);
            this.GroupBox3.TabIndex = 55;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Filter By";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(118, 56);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 21);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(118, 27);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(138, 21);
            this.DateTimePicker1.TabIndex = 0;
            // 
            // rbexpdate
            // 
            this.rbexpdate.AutoSize = true;
            this.rbexpdate.Location = new System.Drawing.Point(138, 92);
            this.rbexpdate.Name = "rbexpdate";
            this.rbexpdate.Size = new System.Drawing.Size(79, 17);
            this.rbexpdate.TabIndex = 4;
            this.rbexpdate.TabStop = true;
            this.rbexpdate.Text = " exp date";
            this.rbexpdate.UseVisualStyleBackColor = true;
            this.rbexpdate.CheckedChanged += new System.EventHandler(this.rbexpdate_CheckedChanged);
            // 
            // rbSorageIn
            // 
            this.rbSorageIn.AutoSize = true;
            this.rbSorageIn.Location = new System.Drawing.Point(31, 92);
            this.rbSorageIn.Name = "rbSorageIn";
            this.rbSorageIn.Size = new System.Drawing.Size(64, 17);
            this.rbSorageIn.TabIndex = 3;
            this.rbSorageIn.TabStop = true;
            this.rbSorageIn.Text = "DateIn";
            this.rbSorageIn.UseVisualStyleBackColor = true;
            this.rbSorageIn.CheckedChanged += new System.EventHandler(this.rbSorageIn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "To Date :";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(30, 35);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(76, 13);
            this.Label5.TabIndex = 3;
            this.Label5.Text = "From Date :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(53, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 54);
            this.panel2.TabIndex = 56;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(5, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(129, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Stocks Report";
            // 
            // ReportFilterMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 385);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportFilterMarket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportFilterMarket";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ReportFilterMarket_Load);
            this.groupBox1.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_load;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.DateTimePicker dateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        internal System.Windows.Forms.RadioButton rbexpdate;
        internal System.Windows.Forms.RadioButton rbSorageIn;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
    }
}