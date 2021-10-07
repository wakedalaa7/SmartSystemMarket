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

namespace SmarSystemMarket
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BuyingForm bf = new BuyingForm();
            bf.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            this.Hide();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "updatecartt";
            cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            int qty = int.Parse(qty_txt.Text);
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = qty;
            float total = float.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            total *= qty;
            cmd.Parameters.Add("@TotalPrice", SqlDbType.Decimal, 18).Value = total;
            clset.cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Broduct Was Success");
            dataGridView1.CurrentRow.Cells[3].Value = qty_txt.Text;
            dataGridView1.CurrentRow.Cells[4].Value = total.ToString();
            clset.cn.Close();
        }
        public static DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            string nameprod = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Delete Product ?", "delete " + nameprod, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeletProFromCart";
                cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                clset.cn.Close();
                MessageBox.Show(nameprod + "Has Deleted", "delete " + nameprod, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = clset.cn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "CartFormSP";
                clset.cn.Open();
                dt.Load(cmd1.ExecuteReader());
                if (dt.Rows.Count < 1)
                    dataGridView1.DataSource = null;
                else
                dataGridView1.DataSource = dt;
                clset.cn.Close();
            }
            else
                MessageBox.Show(nameprod + "In Cart Yet", "Non deleted " + nameprod, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
         public static DataTable dtreg1 = new DataTable();
        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmdd = new SqlCommand();
            cmdd.Connection = clset.cn;
            cmdd.CommandType = CommandType.StoredProcedure;
            cmdd.CommandText = "getpaymentcards4";
            cmdd.Parameters.Add("@Id", SqlDbType.VarChar, 9).Value = login.idd;
            DataTable dt11 = new DataTable();
            SqlDataAdapter da11 = new SqlDataAdapter(cmdd);
            da11.Fill(dt11);
            clset.cn.Open();
            dtreg1.Load(cmdd.ExecuteReader());
            if (dtreg1.Rows.Count > 0)
            {

                
            }
            clset.cn.Close();

            DataTable dtreg = new DataTable();
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "getpaymentcards3";
            cmd2.Parameters.Add("@Id", SqlDbType.VarChar, 9).Value = login.idd;
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dt1);
            clset.cn.Open();
            dtreg.Load(cmd2.ExecuteReader());
            if (dtreg.Rows.Count > 0)
            {
                
                Payment pm = new Payment();
                for (int i = dtreg.Rows.Count - 1; i >= 0; i--)
                {
                    dt1.Rows[i][0] = "****"+dt1.Rows[i][0].ToString().Substring(12);
                }
                pm.dataGridView_visa.DataSource = dt1;
                pm.Show();
                Hide();
            }
            clset.cn.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nameprod = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (MessageBox.Show("Delete Product ?", "delete " + nameprod, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeletProFromprod";
                cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = nameprod;
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                clset.cn.Close();
                MessageBox.Show(nameprod + "Has Deleted", "delete " + nameprod, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = clset.cn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "invationFormSP";
                clset.cn.Open();
                dt.Load(cmd1.ExecuteReader());
                if (dt.Rows.Count < 1)
                    dataGridView1.DataSource = null;
                else
                    dataGridView1.DataSource = dt;
                clset.cn.Close();
            }
            else
                MessageBox.Show(nameprod + "In Cart Yet", "Non deleted " + nameprod, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
