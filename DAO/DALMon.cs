using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAO
{
    class DALMon
    {
        private static DALMon instance;

        public static DALMon Instance
        {
            get { if (instance == null) instance = new DALMon(); return DALMon.instance; }
            private set { DALMon.instance = value; }
        }

        private DALMon() { }

        public List<DTOMonAn> GetListMenuByTable(int id)
        {
            List<DTOMonAn> listMenu = new List<DTOMonAn>();

            string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Food AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status = 0 AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTOMonAn menu = new DTOMonAn(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
