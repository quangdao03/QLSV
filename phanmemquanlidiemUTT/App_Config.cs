using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace phanmemquanlidiemUTT
{
    class App_Config
    {
        // Hàm này để kết nối đến cơ sở dữ liệu
        String connection = ConfigurationManager.ConnectionStrings["phanmemquanlidiemUTT.Properties.Settings.UTTquanlisvConnectionString"].ConnectionString;
        public int InsertDb(String sql)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
            int i = -1;
            try
            {
                // mở kết nối đến csdl 
                con.Open();
                i = cmd.ExecuteNonQuery();

            }
            catch
            {
                i = -1;

            }
            finally
            {
                con.Close();


            }
            return i;
        }
        public DataTable SelectDb(String sql)
        {
            SqlConnection con = new SqlConnection(connection);
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                // mở kết nối đến csdl 
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                tb.Load(dr, LoadOption.OverwriteChanges);

                if (tb.Rows.Count == 0)
                {
                    return null;
                }


            }
            catch
            {

            }
            finally
            {
                con.Close();

            }
            return tb;
        }
    }
}
