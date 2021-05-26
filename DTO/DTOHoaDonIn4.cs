using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DTOHoaDonIn4
    {
        public DTOHoaDonIn4(int id,int billID,int foodID,int count)
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;
        }

        public DTOHoaDonIn4(DataRow row)
        {
            ID = (int)row["id"];
            BillID = (int)row["idBill"];
            FoodID = (int)row["idFoof"];
            Count = (int)row["count"];
        }
        
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private int foodID;
        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }
        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
