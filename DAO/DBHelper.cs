using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class DBHelper
    {
        private SqlConnection cnn;
        private static DBHelper _Instance;
        public static DBHelper Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cmt = @"Data Source=DESKTOP-UELNR5R\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True;";
                    _Instance = new DBHelper(cmt);
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecords1(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
