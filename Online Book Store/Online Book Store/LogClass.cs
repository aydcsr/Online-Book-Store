using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class LogClass
    {
        private string customerid;
        private string btnName;
        private string frmName;
        private string date;
        public LogClass(string customerId,string btnName,string frmName,string date)
        {
            this.customerid = customerId;
            this.btnName = btnName;
            this.frmName = frmName;
            this.date = date;
        }
        public string BtnName { get => btnName; set => btnName = value; }
        public string FrmName { get => frmName; set => frmName = value; }
        public string Date { get => date; set => date = value; }
        public string Customerid { get => customerid; set => customerid = value; }
    }
}
