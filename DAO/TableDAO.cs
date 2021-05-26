using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.DAO
{
    class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 50;
        public static int TableHeight = 50;

        private TableDAO() { }

        public List<DTOTable> LoadTableList()
        {
            List<DTOTable> tableList = new List<DTOTable>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_getTableList");

            foreach (DataRow item in data.Rows)
            {
                DTOTable table = new DTOTable(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
