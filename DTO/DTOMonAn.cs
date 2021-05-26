using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class DTOMonAn
    {
        public DTOMonAn(string foodname, int count, float price,float totalprice = 0)
        {
            this.Foodname = foodname;
            this.Count = count;
            this.Price = price;
            this.Totalprice = totalprice;
        }
        public DTOMonAn(DataRow row)
        {
            this.Foodname = row["Name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }
        private string foodname;
        public string Foodname
        {
            get { return foodname; }
            set { foodname = value; }
        }

        private int count;
        public int Count
        {   
            get { return count; }
            set { count = value; }
        }

        private float price;
        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        private float totalprice;
        public float Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
    }
}
