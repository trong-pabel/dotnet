/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DAO
{
    class DALNhanVien
    {
        private static DALNhanVien _Instance;
        public static DALNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DALNhanVien();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private DALNhanVien()
        {

        }
        public List<User> GetAllUser()
        {
            List<User> data = new List<User>();
            string query = "select * from _User";
            foreach (DataRow i in DBhelper.Instance.GetRecords1(query).Rows)
            {
                data.Add(GetUser(i));
            }
            return data;
        }
        public User GetUser(DataRow i)
        {
            return new User
            {
                ID_User = i["ID_User"].ToString(),
                UserName = i["UserName"].ToString(),
                Email = i["Email"].ToString(),
                Phone_Number = i["Phone_Number"].ToString(),
                Address_User = i["Address_User"].ToString(),
                User_PW = i["User_PW"].ToString(),
            };
        }
        public List<Admin> GetAllAdmin()
        {
            List<Admin> data = new List<Admin>();
            string query = "select * from _Admin";
            foreach (DataRow i in DBhelper.Instance.GetRecords1(query).Rows)
            {
                data.Add(GetAdmin(i));
            }
            return data;
        }
        public Admin GetAdmin(DataRow i)
        {
            return new Admin
            {
                ID_Admin = i["ID_Admin"].ToString(),
                AdminName = i["AdminName"].ToString(),
                Email = i["Email"].ToString(),
                Phone_Number = i["Phone_Number"].ToString(),
                Address_Admin = i["Address_Admin"].ToString(),
                Admin_PW = i["Admin_PW"].ToString(),
            };
        }
        public void AddUser(User s)
        {
            string query = "INSERT INTO _User VALUES( " + " N'" + s.ID_User.ToString() + "'" + ", N'" + s.UserName.ToString() + "'" + ", N'" + s.Email.ToString() + "'" + ", N'" + s.Phone_Number.ToString() + "'" + ", N'" + s.Address_User.ToString() + "'" + ",N'" + s.User_PW.ToString() + "'" + ");"; // them cau query vao
            DBhelper.Instance.ExecuteDB(query);
        }
        public void EditUser(User s)
        {
            string query = "UPDATE _User SET UserName=" + "N'" + s.UserName.ToString() + "' , Email= N'" + s.Email.ToString() + "', Address_User=N'" + s.Address_User.ToString() + "'" + ",User_PW=N'" + s.User_PW.ToString() + "'" + "WHERE ID_User= " + " N'" + s.ID_User.ToString() + "'" + ";";
            DBhelper.Instance.ExecuteDB(query);
        }
        public void DeleteUser(User s)
        {
            string query = "DELETE FROM _User WHERE Phone_Number=" + s.Phone_Number + ";";
            DBhelper.Instance.ExecuteDB(query);
        }
    }
}
*/