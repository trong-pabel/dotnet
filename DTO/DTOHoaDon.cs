using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class DTOHoaDon
    {
        public DTOHoaDon(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        { 
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public DTOHoaDon(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime)row["dateCheckIn"];
            this.DateCheckOut = (DateTime)row["dateCheckOut"];
            this.Status = (int)row["status"];
        }
        private int status;
        public int Status
        {
            get { return Status; }
            set { Status = value; }
        }
        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn// gia tri co the null
        {
            get { return DateCheckIn; }
            set { DateCheckIn = value; }
        }
        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return DateCheckOut; }
            set { DateCheckOut = value; }
        }
        private int iD;
        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }
    }
}
