using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace SmarSystemMarket
{
    public partial class emotform : Form
    {
        public static string strtext;
        public static string id = "";
        public emotform()
        {
            InitializeComponent();
            ActiveControl = id_txt;
        }

        private void emotform_Load(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if(int.Parse(id_txt.Text)==login.emot)            
            {
                int flag = 0;

                flag = ClsUsers.login2(id);
                if (flag == 1)
                {
                    Menahel men = new Menahel();
                    flag = 0;
                    men.Show();
                    Close();
                    
                }
                else
                {
                    flag = ClsUsers.login1(id);
                    if (flag == 1)
                    {
                        BuyingForm bf = new BuyingForm();
                        flag = 0;
                        bf.Show();
                        Close();

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login ln = new login();
            ln.Show();
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (int.Parse(id_txt.Text) == Payment.emot)
            {
                strtext = DateTime.Now.ToString()+"\n\n\n";
                DataTable dtcart = new DataTable();
                MessageBox.Show(" The Payment Was Success!! ");
                MessageBox.Show(" Thank You For Buying From Us!! ");
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = clset.cn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "CartFormSP";
                clset.cn.Open();
                dtcart.Load(cmd1.ExecuteReader());
                clset.cn.Close();
                if (dtcart.Rows.Count > 0)
                {
                    DataTable dtproduct = new DataTable();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = clset.cn;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "invationFormSP";
                    clset.cn.Open();
                    dtproduct.Load(cmd2.ExecuteReader());
                    clset.cn.Close();
                    if (dtproduct.Rows.Count > 0)
                    {
                        int cartqty;
                        string cartbar;
                        int prodqty;
                        string prodbar;
                        string prodname;
                        for(int i=dtcart.Rows.Count-1;i>=0;i--)
                        {
                            cartbar = dtcart.Rows[i][1].ToString();
                            cartqty = int.Parse(dtcart.Rows[i][3].ToString());
                            for (int j = dtproduct.Rows.Count - 1; j >= 0; j--)
                            {
                                prodbar = dtproduct.Rows[j][0].ToString();
                                prodqty = int.Parse(dtproduct.Rows[i][4].ToString());
                                prodname = dtproduct.Rows[j][2].ToString();
                                if (prodbar==cartbar)
                                {
                                    prodqty -= cartqty;
                                    if (prodqty >= 0)
                                    {
                                        DataTable ubdateqty = new DataTable();
                                        SqlCommand cmd4 = new SqlCommand();
                                        cmd4.Connection = clset.cn;
                                        cmd4.CommandType = CommandType.StoredProcedure;
                                        cmd4.CommandText = "updateproduct2";
                                        cmd4.Parameters.Add("@barcode", SqlDbType.VarChar, 100).Value = prodbar;
                                        cmd4.Parameters.Add("@Qty", SqlDbType.Int).Value = prodqty;
                                        clset.cn.Open();
                                        cmd4.ExecuteNonQuery();
                                        clset.cn.Close();
                                    }
                                    
                                        if (prodqty<50)
                                    {
                                        DataTable dtmen = new DataTable();
                                        SqlCommand cmd3 = new SqlCommand();
                                        cmd3.Connection = clset.cn;
                                        cmd3.CommandType = CommandType.StoredProcedure;
                                        cmd3.CommandText = "mentableSP";
                                        clset.cn.Open();
                                        string menphone;
                                        string menemail;
                                        dtmen.Load(cmd3.ExecuteReader());
                                        clset.cn.Close();
                                        if (dtmen.Rows.Count > 0)
                                        {
                                                menphone = dtmen.Rows[0][3].ToString();
                                                menemail = dtmen.Rows[0][7].ToString();
                                                ClsUsers.SendMessegeForMenahel(menphone,menemail,prodqty, prodname, prodbar);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                for (int i = dtcart.Rows.Count - 1; i >= 0; i--)
                {

                    if (dtcart.Rows.Count > 0)
                    {
                        strtext += "product name :- " + dtcart.Rows[i][0].ToString()
                            + " product barcode :-" + dtcart.Rows[i][1].ToString()
                            + " product qty :-" + dtcart.Rows[i][3].ToString()
                            + " total price :-" + dtcart.Rows[i][4].ToString() + "\n\n";                         
                    }
                }
                strtext+= "--------------------------------------------------------------------------------------------------------------------";
                StreamWriter sw = new StreamWriter("report stock out.txt",true);
                sw.WriteLine(strtext);
                sw.Close();
                SqlCommand cmd6 = new SqlCommand();
                cmd6.Connection = clset.cn;
                cmd6.CommandType = CommandType.StoredProcedure;
                cmd6.CommandText = "DeleteCart1";
                clset.cn.Open();
                cmd6.ExecuteNonQuery();
                clset.cn.Close();
                ClsUsers.SendCart(strtext, login.PhNumber, login.Email);
                Application.Restart();
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
