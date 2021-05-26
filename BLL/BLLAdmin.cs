/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.BLL
{
    class BLLAdmin
    {
        public delegate bool Compare(User sv1, User sv2);
        private static BLLAdmin _Instance;
        public static BLLAdmin Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLAdmin();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private BLLAdmin()
        {
        }
        public List<Admin> GetListAdmin()
        {
            List<Admin> data = new List<Admin>();
            data = DAL_QLUser.Instance.GetAllAdmin();
            return data;
        }
        public List<User> GetListUser(string name, string sx)
        {
            List<User> data = new List<User>();
            if (name == null)
            {
                data = DAL_QLUser.Instance.GetAllUser();
            }
            else
            {
                foreach (User i in DAL_QLUser.Instance.GetAllUser())
                {
                    if (i.UserName == name)
                    {
                        data.Add(i);
                    }
                }
            }
            SapXep(data, sx);
            return data;
        }
        public User GetUsetByID(string ID)
        {

            foreach (User i in DAL_QLUser.Instance.GetAllUser())
            {
                if (i.ID_User == ID)
                {
                    return i;
                }
            }
            return null;
        }
        public void CheckDB(User s)
        {
            bool check = false;
            foreach (User i in GetListUser(null, null))
            {
                if (i.ID_User == s.ID_User)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                BLL_QLUser.Instance.EditUser(s);
            }
            else
            {
                BLL_QLUser.Instance.AddUser(s);
            }
        }
        public void AddUser(User s)
        {
            DAL_QLUser.Instance.AddUser(s);
        }
        public void DeleteUser(User s)
        {
            DAL_QLUser.Instance.DeleteUser(s);
        }
        public void EditUser(User s)
        {
            DAL_QLUser.Instance.EditUser(s);
        }
        public void sort(List<User> user, Compare cmp)
        {
            for (int i = 0; i < user.Count - 1; i++)
            {
                for (int j = i + 1; j < user.Count; j++)
                {
                    if (cmp(user[i], user[j]))
                    {
                        User s = user[i];
                        user[i] = user[j];
                        user[j] = s;
                    }
                }
            }
        }
        public void SapXep(List<User> data, string sx)
        {
            switch (sx)
            {
                case "ID Tăng Dần":
                    sort(data, User.ID_tang);
                    break;
                case "ID Giảm Dần":
                    sort(data, User.ID_giam);
                    break;
                case "Name Tăng Dần":
                    sort(data, User.Name_Tang);
                    break;
                case "Name Giảm Dần":
                    sort(data, User.Name_Giam);
                    break;
            }
        }
    }
}
*/