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
    public partial class Menahel : Form
    {
        
        public Menahel()
        {
            InitializeComponent();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Cart Storage = new Cart();
            Storage.button_delete_cart.Visible = false;
            Storage.button_delete_storage.Visible = true;
            Storage.button_pay.Visible = false;
            Storage.button_back_cus.Visible = false;
            Storage.button_back_mnahel.Visible = true;
            Storage.label_storage.Visible = true;
            Storage.label_cart.Visible = false;
            Storage.button_save.Visible = false;
            Storage.qty_txt.Visible = false;
            Storage.label_edit.Visible = false;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "invationFormSP";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            clset.cn.Open();

            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count > 0)
            {



                Storage.dataGridView1.DataSource = dt1;
                DataGridViewImageColumn dvgimg = new DataGridViewImageColumn();
                dvgimg = (DataGridViewImageColumn)Storage.dataGridView1.Columns[5];
                dvgimg.ImageLayout = DataGridViewImageCellLayout.Stretch;
                Storage.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Storage.dataGridView1.RowTemplate.Height = 120;
            }

            clset.cn.Close();
            Storage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            BuyingForm buyf = new BuyingForm();
            buyf.back_button_mnahel.Visible = true;
            buyf.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProduct Addpro = new EditProduct();
            Addpro.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct AddproSt = new AddProduct();
            AddproSt.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Hide();

        }

        private void Menahel_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.SaveAdmin_btn.Visible = true;
            reg.button_back_menahel.Visible = true;
            reg.button_back_cus.Visible = false;
            reg.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MangersTable mangers = new MangersTable();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "mentableSsP";
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt1);
            clset.cn.Open();

            dt.Load(cmd.ExecuteReader());
            if (dt.Rows.Count > 0)
            {


                mangers.dataGridVie_manger.DataSource = dt1;
                mangers.dataGridVie_manger.RowTemplate.Height = 120;
            }

            clset.cn.Close();
            mangers.Show();
            this.Hide();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            ReportFilterMarket reportFilter = new ReportFilterMarket();
            reportFilter.Show();
            Hide();
        }
    }
}
