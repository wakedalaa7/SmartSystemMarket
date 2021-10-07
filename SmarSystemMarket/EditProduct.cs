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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }
        public static int checkflag = 0;
        public static string BarCode = "";
        public static DataTable dt = new DataTable();
        private void button3_Click(object sender, EventArgs e)
        {
            checkflag = 0;
            BarCode = barcode_txt.Text.ToString();
            if (barcode_txt.Text != "")
            {
                checkflag = ClsAddProduct.CheckProd(BarCode);
                if (checkflag == 0)
                {
                    MessageBox.Show("Prouduct Was Not found In The Stock\nPleaze Added It Here");
                    AddProduct AddproSt = new AddProduct();
                    AddproSt.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Prouduct Was found In The Stock\nYou Can Change The Properties Now");
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = clset.cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ProdFormSP1";
                    cmd.Parameters.Add("@BarCode", SqlDbType.VarChar, 100).Value = barcode_txt.Text;
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt1);
                    clset.cn.Open();
                    dt.Load(cmd.ExecuteReader());
                    if (dt.Rows.Count > 0)
                    {
                        barcode_txt.Text = dt.Rows[0][0].ToString();
                        prod_txt.Text = dt.Rows[0][2].ToString();
                        company_txt.Text = dt.Rows[0][1].ToString();
                        price_txt.Text = dt.Rows[0][3].ToString();
                        qty_txt.Text = dt.Rows[0][4].ToString();
                        barcode_txt.ReadOnly = true;
                        prod_txt.ReadOnly = false;
                        company_txt.ReadOnly = false;
                        price_txt.ReadOnly = false;
                        qty_txt.ReadOnly = false;
                    }
                    clset.cn.Close();
                }
            }
            else
            
            {
                MessageBox.Show("No Barcode has Inserted\nPleaze Insert The Barcode");
                ActiveControl = barcode_txt;
                barcode_txt.ReadOnly = false;
                prod_txt.ReadOnly = true;
                company_txt.ReadOnly = true;
                price_txt.ReadOnly = true;
                qty_txt.ReadOnly = true;
                barcode_txt.Text = "";
                prod_txt.Text = "";
                company_txt.Text = "";
                price_txt.Text = "";
                qty_txt.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkflag = ClsAddProduct.CheckProd(BarCode);
            if (checkflag == 1)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateProd";
                cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = prod_txt.Text;
                int qty = int.Parse(qty_txt.Text);
                float price = float.Parse(price_txt.Text);
                cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = qty;
                cmd.Parameters.Add("@ProdPrice", SqlDbType.Decimal, 18).Value = price;
                cmd.Parameters.Add("@Company", SqlDbType.VarChar, 10).Value = company_txt.Text;
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Broduct Was Success");
                clset.cn.Close();
                MessageBox.Show("You Can Ubdate Another Product");
                ActiveControl = barcode_txt;
                barcode_txt.ReadOnly = false;
                prod_txt.ReadOnly = true;
                company_txt.ReadOnly = true;
                price_txt.ReadOnly = true;
                qty_txt.ReadOnly = true;
                barcode_txt.Text = "";
                prod_txt.Text = "";
                company_txt.Text = "";
                price_txt.Text = "";
                qty_txt.Text = "";
            }
            else
            {
                if (barcode_txt.Text != "")
                {
                    MessageBox.Show("Prouduct Was Not found In The Stock\nPleaze Added It Here");
                    AddProduct AddproSt = new AddProduct();
                    AddproSt.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("No Barcode has Inserted\nPleaze Insert The Barcode");
                    ActiveControl = barcode_txt;
                    barcode_txt.ReadOnly = false;
                    prod_txt.ReadOnly = true;
                    company_txt.ReadOnly = true;
                    price_txt.ReadOnly = true;
                    qty_txt.ReadOnly = true;
                    barcode_txt.Text = "";
                    prod_txt.Text = "";
                    company_txt.Text = "";
                    price_txt.Text = "";
                    qty_txt.Text = "";
                }
            }
        }

        private void AddEditProduct_Load(object sender, EventArgs e)
        {
            ActiveControl = barcode_txt;
            prod_txt.ReadOnly = true;
            company_txt.ReadOnly = true;
            price_txt.ReadOnly = true;
            qty_txt.ReadOnly = true;
        }
    }
}
