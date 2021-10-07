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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            ActiveControl = txt_f_name;
        }

        private void register_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_visa_page_Click(object sender, EventArgs e)
        {
            if (txt_f_name.Text!= "" && txt_L_name.Text != "" && txt_ID.Text != "" && txt_phone_number.Text != "")
            {
                visa_card visaform = new visa_card();
                visaform.Show();
                Hide();
                visa_card.CosInformation(txt_f_name.Text.ToString(), txt_L_name.Text.ToString(), txt_ID.Text.ToString(), txt_phone_number.Text.ToString(),email_txt.Text.ToString());
                MessageBox.Show("please continue", "continue ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("please insert all your info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveAdmin_btn_Click(object sender, EventArgs e)
        {
            if (txt_ID.TextLength == 9)
            {
                DataTable dtreg = new DataTable();
                int flag = 0;
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = clset.cn;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.CommandText = "CheckManger";
                cmd2.Parameters.Add("@Id", SqlDbType.VarChar, 9).Value = txt_ID.Text;
                clset.cn.Open();
                dtreg.Load(cmd2.ExecuteReader());
                if (dtreg.Rows.Count > 0)
                {
                    flag = 1;

                }
                dtreg.Reset();
                clset.cn.Close();
                if (flag == 0)
                {

                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = clset.cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "InsertMang";
                    cmd.Parameters.Add("@idmang", SqlDbType.VarChar, 9).Value = txt_ID.Text;
                    cmd.Parameters.Add("@fname", SqlDbType.VarChar, 10).Value = txt_f_name.Text;
                    cmd.Parameters.Add("@lname", SqlDbType.VarChar, 10).Value = txt_L_name.Text;
                    cmd.Parameters.Add("@phonenumber", SqlDbType.VarChar, 10).Value = txt_phone_number.Text;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = email_txt.Text;
                    clset.cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Register Was Success");
                    clset.cn.Close();
                    visa_card.flagok = 1;
                }
                else
                    MessageBox.Show("You Have Acount !!");
            }
            else
            MessageBox.Show("The Id Was Not Currect !!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }
    }
}
