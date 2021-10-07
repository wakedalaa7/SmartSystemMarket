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
    public partial class ReportFilterMarket : Form
    {
        public ReportFilterMarket()
        {
            InitializeComponent();
        }

        private void ReportFilterMarket_Load(object sender, EventArgs e)
        {

        }

        private void rbSorageIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSorageIn.Checked==true)           
                rbexpdate.Checked = false;            
        }

        private void rbexpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbexpdate.Checked == true)
                rbSorageIn.Checked = false;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Menahel menahel = new Menahel();
            menahel.Show();
            Hide();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            if ((rbexpdate.Checked == false) && (rbSorageIn.Checked == false))
            {
                MessageBox.Show("Please select Any report You Choose!!");
            }
            if (rbexpdate.Checked == true)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "betweenexpdate";
                cmd.Parameters.Add("@expdate1", SqlDbType.VarChar, 15).Value = DateTimePicker1.Text;
                cmd.Parameters.Add("@expdate2", SqlDbType.VarChar, 15).Value = dateTimePicker2.Text;
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt1);
                clset.cn.Open();

                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    ReportByExpdate byExpdate = new ReportByExpdate();

                    byExpdate.dataGridView1.DataSource = dt1;
                    DataGridViewImageColumn dvgimg = new DataGridViewImageColumn();
                    dvgimg = (DataGridViewImageColumn)byExpdate.dataGridView1.Columns[3];
                    dvgimg.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    byExpdate.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    byExpdate.dataGridView1.RowTemplate.Height = 120;
                    byExpdate.Show();
                    Hide();
                }
                else
                    MessageBox.Show("There is No Products With expdate Between this Dates!!");
                clset.cn.Close();
            }
            if (rbSorageIn.Checked == true)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BetweenDatein";
                cmd.Parameters.Add("@datin1", SqlDbType.VarChar, 15).Value = DateTimePicker1.Text;
                cmd.Parameters.Add("@datin2", SqlDbType.VarChar, 15).Value = dateTimePicker2.Text;
                DataTable dt1 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt1);
                clset.cn.Open();

                dt.Load(cmd.ExecuteReader());
                if (dt.Rows.Count > 0)
                {
                    ReportStorageIn bydatein = new ReportStorageIn();

                    bydatein.dataGridView1.DataSource = dt1;
                    DataGridViewImageColumn dvgimg = new DataGridViewImageColumn();
                    dvgimg = (DataGridViewImageColumn)bydatein.dataGridView1.Columns[3];
                    dvgimg.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    bydatein.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    bydatein.dataGridView1.RowTemplate.Height = 120;
                    bydatein.Show();
                    Hide();
                }
                else
                    MessageBox.Show("There is No Products With DateIn Between this Dates!!");
                clset.cn.Close();
            }
        }
    }
}