using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SmarSystemMarket
{
    public partial class login : Form
    {
        private readonly Color MenuText;
        public static string PhNumber = "";
        public static string Email = "";
        public static string idd = "";
        public static int emot;
        public login()
        {
            InitializeComponent();
            ActiveControl = txtId;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void jTextBox1_Load(object sender, EventArgs e)
        {
            txtId.ForeColor = MenuText;
        }

        private void start_btn_MouseHover(object sender, EventArgs e)
        {
            start_btn.Text = "Start shopping";
        }

        private void start_btn_MouseLeave(object sender, EventArgs e)
        {
            start_btn.Text = "Click To Start";
        }



        private void register_btn_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
            Hide();
        }

        private void loginlabel_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            idd = txtId.Text;
            int flag = 0;

            flag = ClsUsers.login2(txtId.Text);
            if (flag == 1)
            {
                Random random = new Random();
                emot = random.Next(1000, 10000);
                ClsUsers.SendMessege(emot, PhNumber,Email);
                emotform emf = new emotform();
                emf.Show();
                Hide();
            }
            else
            {
                flag = ClsUsers.login1(txtId.Text);
                if (flag == 1)
                {
                    Random random = new Random();
                    emot = random.Next(1000, 10000);
                    ClsUsers.SendMessege(emot, PhNumber,Email);
                    emotform emf = new emotform();
                    emf.Show();
                    Hide();
                }
            }


        }
    }
}
