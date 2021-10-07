using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace SmarSystemMarket
{
    public partial class AddProduct : Form
    {
        public string imgloc = "";
        public AddProduct()
        {
            InitializeComponent();
            ActiveControl = barcode_txt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int checkflag = 0;
           checkflag=ClsAddProduct.CheckProd(barcode_txt.Text);
            if (checkflag == 0)
            {
                
                    if (barcode_txt.Text != "" && name_txt.Text != "" && company_txt.Text != "" && price_txt.Text != "" &&
                       qty_txt.Text != "" && weight_txt.Text != "")                   
                    {
                        int Qty = int.Parse(qty_txt.Text);
                        float prodprice = float.Parse(price_txt.Text);
                        float Weight = float.Parse(weight_txt.Text);
                        FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(fs);
                        byte[] img = null;
                        img = br.ReadBytes((int)fs.Length);                       
                        ClsAddProduct.Addprodex(barcode_txt.Text, company_txt.Text, Qty, name_txt.Text, prodprice, img, Weight, chooseexpdate.Text, chooseDatein.Text);
                        barcode_txt.Text = "";
                        name_txt.Text = "";
                        company_txt.Text = "";
                        price_txt.Text = "";
                        qty_txt.Text = "";
                        weight_txt.Text = "";
                        pictureBox1.Image = null;
                        barcode_txt.Focus();
                    }
                
            }
            else
            {
                //if found in expdate
                checkflag = ClsAddProduct.Checkexp(chooseexpdate.Text);
                if (checkflag == 1)
                {
                    if (MessageBox.Show("Prouduct Was found In The Stock\nDo Youn Want Edit It ?", "Edit Product", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        EditProduct Addpro = new EditProduct();
                        Addpro.Show();
                        Hide();
                    }
                    else
                    {
                        barcode_txt.Text = "";
                        name_txt.Text = "";
                        company_txt.Text = "";
                        price_txt.Text = "";
                        qty_txt.Text = "";
                        weight_txt.Text = "";
                        pictureBox1.Image = null;
                        barcode_txt.Focus();
                    }
                }
                else
                {
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.Connection = clset.cn;
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "InsertExpdateex2";
                    cmd2.Parameters.Add("@BarCode", SqlDbType.VarChar, 100).Value = barcode_txt.Text;
                    cmd2.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = name_txt.Text;
                    FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    byte[] img = null;
                    img = br.ReadBytes((int)fs.Length);
                    cmd2.Parameters.Add("@ProdImage", SqlDbType.Image).Value = img;
                    cmd2.Parameters.Add("@expdate", SqlDbType.VarChar, 15).Value = chooseexpdate.Text;

                    cmd2.Parameters.Add("@Company", SqlDbType.VarChar, 10).Value = company_txt.Text;
                    cmd2.Parameters.Add("@ProdPrice", SqlDbType.Decimal, 18).Value = price_txt.Text;
                    cmd2.Parameters.Add("@Qty", SqlDbType.Int).Value = qty_txt.Text;
                    cmd2.Parameters.Add("@datein", SqlDbType.VarChar, 15).Value = chooseDatein.Text;
                    clset.cn.Open();
                    cmd2.ExecuteNonQuery();
                    clset.cn.Close();
                    MessageBox.Show("Added Broduct Was Success");
                    barcode_txt.Text = "";
                    name_txt.Text = "";
                    company_txt.Text = "";
                    price_txt.Text = "";
                    qty_txt.Text = "";
                    weight_txt.Text = "";
                    pictureBox1.Image = null;
                    barcode_txt.Focus();
                }
            }
        }

        private void AddEditProductInStock_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stream MyStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(*.jpe;*.jpeg *.bmp;) | *.jpg;*.jpeg *.bmp";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if((MyStream=openFileDialog.OpenFile())!=null)
                    {
                        imgloc = openFileDialog.FileName.ToString();
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
