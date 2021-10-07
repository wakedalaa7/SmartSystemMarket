namespace SmarSystemMarket
{
    partial class MangersTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangersTable));
            this.dataGridVie_manger = new System.Windows.Forms.DataGridView();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVie_manger)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVie_manger
            // 
            this.dataGridVie_manger.AllowUserToAddRows = false;
            this.dataGridVie_manger.AllowUserToDeleteRows = false;
            this.dataGridVie_manger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVie_manger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVie_manger.Location = new System.Drawing.Point(0, 1);
            this.dataGridVie_manger.Name = "dataGridVie_manger";
            this.dataGridVie_manger.ReadOnly = true;
            this.dataGridVie_manger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVie_manger.Size = new System.Drawing.Size(623, 314);
            this.dataGridVie_manger.TabIndex = 1;
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lefttt;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(12, 321);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(52, 54);
            this.button_back.TabIndex = 21;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button3_Click);
            // 
            // MangersTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SmarSystemMarket.Properties.Resources.lognpic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 387);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dataGridVie_manger);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MangersTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangersTable";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MangersTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVie_manger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridVie_manger;
        public System.Windows.Forms.Button button_back;
    }
}