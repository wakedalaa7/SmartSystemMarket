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
    public partial class MangersTable : Form
    {
        public MangersTable()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }

        private void MangersTable_Load(object sender, EventArgs e)
        {

        }
    }
}
