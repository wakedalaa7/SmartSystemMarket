using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmarSystemMarket
{
    class ClsBuyingForm
    {
        public static DataTable dtcart = new DataTable();
        public static float weght = 0;
        
        public static string[] BuyProIMG(string[] barcode)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ProddCosSP2";
            cmd.Parameters.Add("@barcode", SqlDbType.VarChar, 100).Value = barcode[0];
            clset.cn.Open();

            dtcart.Load(cmd.ExecuteReader());
            if (dtcart.Rows.Count > 0)
            {
                barcode[1] = dtcart.Rows[0][2].ToString();
                barcode[2] = dtcart.Rows[0][3].ToString();
                BuyingForm.IMG = (byte[])dtcart.Rows[0][5];
                BuyingForm.weight = float.Parse(dtcart.Rows[0][6].ToString());
            }
            dtcart.Reset();

            clset.cn.Close();
            return barcode;
        }
        
        public static void Addcartimg(int Qty, string ProdName, float ProdPrice, float total, float weight, string barcode, byte[] img)
        {

            int flag = 0;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "CheckCart";
            cmd2.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = ProdName;
            clset.cn.Open();
            dtcart.Load(cmd2.ExecuteReader());
            if (dtcart.Rows.Count > 0)
            {
                flag = 1;

            }
            dtcart.Reset();

            clset.cn.Close();
            if (flag == 1)
            {
                SqlCommand cmd3 = new SqlCommand();
                cmd3.Connection = clset.cn;
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.CommandText = "UpdateQtyCart";
                cmd3.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = ProdName;
                cmd3.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
                cmd3.Parameters.Add("@TotalPrice", SqlDbType.Decimal, 18).Value = total;

                clset.cn.Open();
                cmd3.ExecuteNonQuery();
                clset.cn.Close();
            }

            if (flag == 0)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertProductCart7img";
                cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
                cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = ProdName;
                cmd.Parameters.Add("@ProdPrice", SqlDbType.Decimal, 18).Value = ProdPrice;
                cmd.Parameters.Add("@Total", SqlDbType.Decimal, 18).Value = total;
                cmd.Parameters.Add("@barcode", SqlDbType.VarChar, 100).Value = barcode;
                cmd.Parameters.Add("@ProdImage", SqlDbType.Image).Value = img;
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Broduct Was Success");

                clset.cn.Close();
            }
            weght += weight;
        }
    }
}
