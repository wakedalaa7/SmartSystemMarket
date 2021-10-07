using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace SmarSystemMarket
{
    class ClsUsers
    {

        public static DataTable dtusers = new DataTable();
        public static  int login1(string id)
        {
            int flag = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "loginsp";
            cmd.Parameters.Add ("@id", SqlDbType.VarChar, 9).Value=id;
            clset.cn.Open();
            dtusers.Load(cmd.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {
                flag = 1;
                login.PhNumber = dtusers.Rows[0][3].ToString();
                login.Email = dtusers.Rows[0][4].ToString();
                emotform.id= dtusers.Rows[0][0].ToString();
                
            }
            dtusers.Reset();
            
            clset.cn.Close();
            return flag;
        }
        public static int login2(string id)
        {
            int flag = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = clset.cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "login22sp";
            cmd.Parameters.Add("@id", SqlDbType.VarChar, 9).Value = id;
            clset.cn.Open();
            dtusers.Load(cmd.ExecuteReader());
            if (dtusers.Rows.Count > 0)
            {
                flag = 1;
                login.PhNumber = dtusers.Rows[0][3].ToString();
                login.Email = dtusers.Rows[0][7].ToString();
                emotform.id = dtusers.Rows[0][0].ToString();
            }
            dtusers.Reset();

            clset.cn.Close();
            return flag;
        }
        public static string FName = "";
        public static string LName = "";
        public static string Id = "";
        public static string PhoneNumber = "";
        public static string Email = "";
        public static void AddUser(string visanumber,string secnum,string cardkind)
        {
            FName = visa_card.FName;
            LName = visa_card.LName;
            Id = visa_card.Id;
            PhoneNumber = visa_card.PhoneNumber;
            Email = visa_card.Email;
            int flag = 0;
            DataTable dtreg = new DataTable();
            flag = 0;
            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = clset.cn;
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.CommandText = "CheckCus";
            cmd2.Parameters.Add("@Id", SqlDbType.VarChar, 9).Value = Id;
            clset.cn.Open();
            dtreg.Load(cmd2.ExecuteReader());
            if (dtreg.Rows.Count > 0)
            {
                flag = 1;

            }
            dtreg.Reset();
            clset.cn.Close();
            if (flag == 0)
            {

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = clset.cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertCosWithEmail1";
                cmd.Parameters.Add("@idcos", SqlDbType.VarChar, 9).Value = Id;
                cmd.Parameters.Add("@fname", SqlDbType.VarChar, 10).Value = FName;
                cmd.Parameters.Add("@lname", SqlDbType.VarChar, 10).Value = LName;
                cmd.Parameters.Add("@phonenumber", SqlDbType.VarChar, 10).Value = PhoneNumber;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar, 30).Value = Email;
                clset.cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Register Was Success");
                clset.cn.Close();
                visa_card.flagok = 1;
            }
            else
                MessageBox.Show("you have acount !!");
            flag = 0;

            DataTable dtreg1 = new DataTable();
            SqlCommand cmd3 = new SqlCommand();
            cmd3.Connection = clset.cn;
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.CommandText = "CheckVisa2";
            cmd3.Parameters.Add("@visanum", SqlDbType.VarChar, 16).Value = visanumber;
            clset.cn.Open();
            dtreg1.Load(cmd3.ExecuteReader());
            if (dtreg1.Rows.Count > 0)
            {
                if (dtreg1.Rows[0][0].ToString() == visanumber)
                {
                    flag = 1;
                }
            }
            dtreg1.Reset();
            clset.cn.Close();
            if (flag == 0)
            {
                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = clset.cn;
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "InsertCosvisa";
                cmd1.Parameters.Add("@cardnumber", SqlDbType.VarChar, 16).Value = visanumber;
                cmd1.Parameters.Add("@seccode", SqlDbType.VarChar, 3).Value = secnum;
                cmd1.Parameters.Add("@carkind", SqlDbType.VarChar, 20).Value = cardkind;
                cmd1.Parameters.Add("@idcus", SqlDbType.VarChar, 9).Value = Id;
                clset.cn.Open();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Register Was Success");
                clset.cn.Close();
            }

            else
            {
                MessageBox.Show("this card is already registered !!");
                return;
            }
            
        }
        public static void SendMessege(int aemot,string phone, string EM)
        {
            string email = "smartsystemmarket@gmail.com";
            string pass = "Ssmproject";

            MailMessage message = new MailMessage();
            message.To.Add(EM);
            message.From = new MailAddress(email);
            message.Subject = "Enter The Code on the coba to know that is you!! :" ;
            message.Body = aemot.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod =  SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(email, pass);
            try
            {
                smtp.Send(message);     
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SendMessegeForMenahel( string phone, string EM, int qty, string Productname, string barcode)
        {
            string email = "smartsystemmarket@gmail.com";
            string pass = "Ssmproject";

            MailMessage message = new MailMessage();
            message.To.Add(EM);
            message.From = new MailAddress(email);
            message.Subject = "product lees than 50 in the storage !!";
            message.Body = "qty for: " + Productname + "\nthat have barcode: "+barcode+"\nless than 50";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(email, pass);
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SendCart(string cartt, string phone, string EM)
        {
            string email = "smartsystemmarket@gmail.com";
            string pass = "Ssmproject";

            MailMessage message = new MailMessage();
            message.To.Add(EM);
            message.From = new MailAddress(email);
            message.Subject = "Smart System Market :";
            message.Body = cartt;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(email, pass);
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
