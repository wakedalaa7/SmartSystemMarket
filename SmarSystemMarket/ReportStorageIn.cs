﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarSystemMarket
{
    public partial class ReportStorageIn : Form
    {
        public ReportStorageIn()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ReportFilterMarket rfm = new ReportFilterMarket();
            rfm.Show();
            Hide();
        }

        private void ReportStorageIn_Load(object sender, EventArgs e)
        {

        }
    }
}
