using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace BookRoom
{
    /// <summary>
    /// Chứa những hàm xử lý database chung cho tất cả
    /// kết nối
    /// executequẻy
    /// </summary>
    public class DataProvider
    {
        //Khai bao cac thanh phan ket noi va xu ly DB
        SqlConnection cnn; //Ket noi DB
        SqlDataAdapter da; //Xu ly cac cau lenh SQL: Select
        SqlCommand cmd; //Thuc thi cau lenh insert,update,delete
        SqlDataReader read;
        BindingSource code;

        public DataProvider()
        {
            connect();
        }

        private void connect()
        {
            try
            {
                string strCnn = "Data Source=DESKTOP-LHUS8S0\\SQLEXPRESS;Initial Catalog=Hotel_Manager;Integrated Security=True";
                //string strCnn = ConfigurationManager.ConnectionStrings["DBConnect"].ConnectionString;
                cnn = new SqlConnection(strCnn);
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
                cnn.Open();
                Console.WriteLine("Connect success!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi ket noi:" + ex.Message);
            }
        }

        //Hàm execute 1 câu lệnh select
        public DataTable executeQuery(string strSelect)
        {
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(strSelect, cnn);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Execute fail:" + ex.Message);
            }
            return dt;
        }

        //Hàm lay ten ra text Box
        public string load_one_colums(string strSelect, string colums)
        {
            string ten = "";
            DataTable dt = new DataTable();
            try
            {
                da = new SqlDataAdapter(strSelect, cnn);
                da.Fill(dt);
                code = new BindingSource();

                foreach (DataRow anh in dt.Rows)
                {
                    code.Add(anh);
                }

                DataRow curent = (DataRow)code.Current;
                ten = curent[colums.ToString()].ToString();                
            }
            catch (Exception)
            {
                Console.WriteLine("Loi");
            }
            return ten;
        }


        //Hàm execute câu lệnh insert,update,delete
        public bool executeNonQuery(string strSQL)
        {
            try
            {
                cmd = cnn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.ExecuteNonQuery();   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Insert/Update/Delete error:"+ex.Message);
                return false;
            }
            return true;
        }
    }
}
