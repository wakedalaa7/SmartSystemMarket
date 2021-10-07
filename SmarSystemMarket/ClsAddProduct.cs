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
    class ClsAddProduct
    {
        public static DataTable dtusers = new DataTable();
       
        public static int CheckProd(string BarCode)
        {
            int checkflag = 0;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "CheckProd";
            cmd2.Parameters.Add("@BarCode", SqlDbType.VarChar, 100).Value = BarCode;
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dtusers);
            clset.cn.Open();
            dtusers.Load(cmd2.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {
                checkflag = 1;

            }
            dtusers.Reset();

            clset.cn.Close();
            
                return checkflag;
        }
        public static int Checkexp(string expdate)
        {
            int checkflag = 0;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "Checkexpdate";
            cmd2.Parameters.Add("@expdate", SqlDbType.VarChar, 15).Value = expdate;
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            da.Fill(dtusers);
            clset.cn.Open();
            dtusers.Load(cmd2.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {
                checkflag = 1;

            }
            dtusers.Reset();

            clset.cn.Close();

            return checkflag;
        }
        
        public static void Addprodex(string BarCode, string Company, int Qty, string ProdName, float ProdPrice, byte[] img, float Weight, string expdate, string datein)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertProductex2" /*"InsertProductImgSPwithweight"*/;
            cmd.Parameters.Add("@BarCode", SqlDbType.VarChar, 100).Value = BarCode;
            cmd.Parameters.Add("@Company", SqlDbType.VarChar, 10).Value = Company;
            cmd.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = ProdName;
            cmd.Parameters.Add("@ProdPrice", SqlDbType.Decimal, 18).Value = ProdPrice;
            cmd.Parameters.Add("@ProdImage", SqlDbType.Image).Value = img;
            cmd.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
            cmd.Parameters.Add("@Weight", SqlDbType.Decimal, 18).Value = Weight;
            cmd.Parameters.Add("@datein", SqlDbType.VarChar, 15).Value = datein;
            clset.cn.Open();
            cmd.ExecuteNonQuery();
            clset.cn.Close();

            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "InsertExpdateex2";
            cmd2.Parameters.Add("@BarCode", SqlDbType.VarChar, 100).Value = BarCode;
            cmd2.Parameters.Add("@ProdName", SqlDbType.VarChar, 10).Value = ProdName;
            cmd2.Parameters.Add("@ProdImage", SqlDbType.Image).Value = img;
            cmd2.Parameters.Add("@expdate", SqlDbType.VarChar, 15).Value = expdate;

            cmd2.Parameters.Add("@Company", SqlDbType.VarChar, 10).Value = Company;
            cmd2.Parameters.Add("@ProdPrice", SqlDbType.Decimal, 18).Value = ProdPrice;
            cmd2.Parameters.Add("@Qty", SqlDbType.Int).Value = Qty;
            cmd2.Parameters.Add("@datein", SqlDbType.VarChar, 15).Value = datein;
            clset.cn.Open();
            cmd2.ExecuteNonQuery();
            clset.cn.Close();
            MessageBox.Show("Added Broduct Was Success");
        }
    }

}
