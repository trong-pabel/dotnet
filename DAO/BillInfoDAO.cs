using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PBL3.DTO;

namespace PBL3.DAO
{
    class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }

        private BillInfoDAO() { }

        public List<DTOHoaDonIn4> GetListBillInfo(int id)
        {
            List<DTOHoaDonIn4> listBillInfo = new List<DTOHoaDonIn4>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.BillInfo WHERE idBill = " + id);

            foreach (DataRow item in data.Rows)
            {
                DTOHoaDonIn4 info = new DTOHoaDonIn4(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
    }
}
