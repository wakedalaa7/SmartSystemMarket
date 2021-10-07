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
    public partial class Payment : Form
    {
        public static string Visanum="";
        public static string SecCode = "";
        public static string Id = "";
        public static int emot;
        public static bool WithCart = false;
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            emot = random.Next(1000, 10000);
            ClsUsers.SendMessege(emot,login.PhNumber,login.Email);
            emotform emf = new emotform();
            emf.button_back_login.Visible = false;
            emf.button_finish.Visible = true;
            emf.button_back_payment.Visible = true;
            emf.start_btn_mnahel_cus.Visible = false;
            emf.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView_visa.CurrentRow.Index; 
            for (int i = Cart.dtreg1.Rows.Count - 1; i >= 0; i--)
            {
                if (rowindex == i)
                {
                    Visanum = Cart.dtreg1.Rows[i][0].ToString();
                    SecCode = Cart.dtreg1.Rows[i][1].ToString();
                    Id = Cart.dtreg1.Rows[i][3].ToString();
                }
            }
            visa_card vc = new visa_card();
            vc.button_login.Visible = false;
            vc.button_back_regstir.Visible = false;
            vc.button_payment.Visible = true;
            vc.button_back_payment.Visible = true;
            visa_card.Id = Id;
            vc.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CartFormSP";
            DataTable dt1 = new DataTable();
            DataTable dt = new DataTable();
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
        }
    }
}
