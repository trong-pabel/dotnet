using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAO
{
    class BILLDAO
    {
        private static BILLDAO instance;

        public static BILLDAO Instance
        {
            get { if (instance == null) instance = new BILLDAO(); return BILLDAO.instance; }
            private set { BILLDAO.instance = value; }
        }

        private BILLDAO() { }

        /// <summary>
        /// Thành công: bill ID
        /// thất bại: -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUncheckBillIDByTableID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Bill WHERE idTable = " + id + " AND status = 0");

            if (data.Rows.Count > 0)
            {
                DTOHoaDon bill = new DTOHoaDon(data.Rows[0]);
                return bill.ID;
            }

            return -1;
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE dbo.Bill SET status = 1 WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
