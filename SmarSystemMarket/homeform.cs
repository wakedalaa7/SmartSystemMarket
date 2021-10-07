using System;
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
    public partial class homeform : Form
    {
        public homeform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            button_start.Visible = false;
            
            
        }

        private void homeform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal static bool ActiveForm()
        {
            throw new NotImplementedException();
        }
    }
}
