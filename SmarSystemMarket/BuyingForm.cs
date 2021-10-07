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
using System.IO;

namespace SmarSystemMarket
{
    public partial class BuyingForm : Form
    {
        public static byte[] IMG;
        public static float weight = 0;
        public BuyingForm()
        {
            InitializeComponent();

        }
        public static DataTable dt = new DataTable();
        private void button7_Click(object sender, EventArgs e)
        {
  
        }

        private void BuyingForm_Load(object sender, EventArgs e)
        {
 
        }
        public void Panelvis ()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Cart Will Delete !!!", "Continue ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteCart1";
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                clset.cn.Close();
                login ln = new login();
                ln.Show();
                Hide();
            }
            else
            {
                ActiveControl = bar_txt;
                bar_txt.ReadOnly = false;
                prod_name_txt.ReadOnly = true;
                price_txt.ReadOnly = true;
                totla_txt.ReadOnly = true;
                totla_txt.ReadOnly = true;
                MessageBox.Show("You Can Continue", "Non deleted ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Your Cart Will Delete !!!", "Continue ?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteCart1";
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                clset.cn.Close();
                Menahel men = new Menahel();
                men.Show();
                Close();
            }
            else
            {
                ActiveControl = bar_txt;
                bar_txt.ReadOnly = false;
                prod_name_txt.ReadOnly = true;
                price_txt.ReadOnly = true;
                totla_txt.ReadOnly = true;
                totla_txt.ReadOnly = true;
                MessageBox.Show("You Can Continue", "Non deleted ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string[] barcode = new string[3];
            barcode[0] = bar_txt.Text;
            barcode = ClsBuyingForm.BuyProIMG(barcode);
            if (IMG == null)
            {
                
                prod_pic.Image = null;
            }
            else
            {
                prod_name_txt.Text = barcode[1];
                price_txt.Text = barcode[2];

                prod_name_txt.ReadOnly = true;
                price_txt.ReadOnly = true;
                MemoryStream mms = new MemoryStream(IMG);
                prod_pic.Image = Image.FromStream(mms);
            }

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            bar_txt.ReadOnly = false;
            prod_name_txt.ReadOnly = false;
            price_txt.ReadOnly = false;
            totla_txt.ReadOnly = false;
            if (bar_txt.Text != "" && prod_name_txt.Text != "" && price_txt.Text != "" && qty_txt.Text != "" && totla_txt.Text != "" )
            {
                weight *= float.Parse(qty_txt.Text);

                ClsBuyingForm.Addcartimg(int.Parse(qty_txt.Text), prod_name_txt.Text, float.Parse(price_txt.Text), float.Parse(totla_txt.Text), weight, bar_txt.Text,IMG);
                ActiveControl = bar_txt;
                bar_txt.Text = "";
                prod_name_txt.Text = "";
                price_txt.Text = "";
                qty_txt.Text = "";
                totla_txt.Text = "";
                prod_pic.Image = null;
            }
            
        }



        private void button3_Click(object sender, EventArgs e)
        {
            ActiveControl = bar_txt;
            int Qty = int.Parse(qty_txt.Text); ;
            if (prod_name_txt.ReadOnly == true && Qty < 50 && Qty > 0)
            {
                bar_txt.ReadOnly = true;
                totla_txt.ReadOnly = true;
                float price = float.Parse(price_txt.Text);
                float total = Qty * price;
                totla_txt.Text = total.ToString();
            }
            else
            {             
                MessageBox.Show("pleae check up your qty!!");
            }
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CartFormSP";
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt1);
                clset.cn.Open();
                
                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    Cart cart = new Cart();
                  
                  cart.dataGridView1.DataSource = dt1;
                  DataGridViewImageColumn dvgimg = new DataGridViewImageColumn();
                  dvgimg = (DataGridViewImageColumn)cart.dataGridView1.Columns[5];
                  dvgimg.ImageLayout = DataGridViewImageCellLayout.Stretch;
                  cart.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                  cart.dataGridView1.RowTemplate.Height = 120;
                cart.Show();
                    Hide();
                }
                
                clset.cn.Close();

            MessageBox.Show("The Weight For Your Cart Is :  "+ClsBuyingForm.weght.ToString()
                +" KG\nAnd That Equals The Products weight."+
                ",That Say You Have'nt Forget Any Thing. \nYou Can Continue Now");

        }
    }
}