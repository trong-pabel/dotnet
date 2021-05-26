using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    public class AccountDAO
    {
        private static AccountDAO _Instance;
        public static AccountDAO Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new AccountDAO();
                return _Instance;
            }
            private set { _Instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username,string password)
        {
            
            string query = "SELECT * FROM dbo.Account WHERE UserName = N'" + username + "' AND PassWord = N'" + password + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
            
        }
    }
}
