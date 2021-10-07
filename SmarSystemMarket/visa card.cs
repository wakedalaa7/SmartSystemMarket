using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmarSystemMarket
{
    
    public partial class visa_card : Form
    {
        public static string FName = "";
        public static string LName = "";
        public static string Id = "";
        public static string PhoneNumber = "";
        public static string Email = "";
        public static int flagok=0;
        public visa_card()
        {
            InitializeComponent();
        }
        public static void CosInformation(string fName, string lName, string id, string phoneNumber, string email)
        {
            FName = fName;
            LName = lName;
            Id = id;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(master_card.Checked==true)
            {
                visa.Checked = false;
            }
        }

        private void visa_card_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            register registerform = new register();
            registerform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txt_visa_number.Text.Length == 16 && txt_sec.Text.Length == 3)&&(master_card.Checked==true||visa.Checked==true))
            {
                string cardkind="";

                if (master_card.Checked == true)
                    cardkind = "Master Card";
                if(visa.Checked==true)
                    cardkind = "visa";
                 ClsUsers.AddUser(txt_visa_number.Text, txt_sec.Text, cardkind);
                if (MessageBox.Show("ARE You Want To Add Another Visa ?", "Another Visa ?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txt_visa_number.Text = "";
                    txt_sec.Text = "";
                }
                else
                {
                    login lg = new login();
                    lg.Show();
                    Hide();
                }
            }
        }

        private void visa_CheckedChanged(object sender, EventArgs e)
        {
            if (visa.Checked == true)
            {

                master_card.Checked = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txt_visa_number.Text.Length == 16 && txt_sec.Text.Length == 3) && (master_card.Checked == true || visa.Checked == true))
            {
                string cardkind = "";

                if (master_card.Checked == true)
                    cardkind = "Master Card";
                if (visa.Checked == true)
                    cardkind = "visa";
                ClsUsers.AddUser(txt_visa_number.Text, txt_sec.Text, cardkind);
                if (MessageBox.Show("ARE You Want To Add Another Visa ?", "Another Visa ?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txt_visa_number.Text = "";
                    txt_sec.Text = "";
                }
                else
                {
                    DataTable dtreg = new DataTable();

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = clset.cn;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "getpaymentcards2";
                    cmd2.Parameters.Add("@Id", SqlDbType.VarChar, 9).Value = login.idd;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(dt1);
                    clset.cn.Open();
                    dtreg.Load(cmd2.ExecuteReader());
                    if (dtreg.Rows.Count > 0)
                    {

                        Payment pm = new Payment();

                        pm.dataGridView_visa.DataSource = dt1;
                        pm.Show();
                        Hide();
                    }
                    dtreg.Reset();
                    clset.cn.Close();
                }
            }
            
            else
            MessageBox.Show("Please Insert Your Visa Information");
            

        }

        private void button4_Click(object sender, EventArgs e)
        {

            DataTable dtreg = new DataTable();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "getpaymentcards2";
            cmd2.Parameters.Add("@Id", SqlDbType.VarChar, 9).Value = login.idd;
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt1);
            clset.cn.Open();
            dtreg.Load(cmd2.ExecuteReader());
            if (dtreg.Rows.Count > 0)
            {

                Payment pm = new Payment();

                pm.dataGridView_visa.DataSource = dt1;
                pm.Show();
                Hide();
            }
            dtreg.Reset();
            clset.cn.Close();
        }
    }
}
