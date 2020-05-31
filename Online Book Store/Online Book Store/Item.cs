using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    public partial class Item : Form
    {
        DatabaseClass db = DatabaseClass.createConnection("onlineSales"); 
        public Item()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            if(LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnClose.Name, "Item", Util.GetTime());
                db.insertLog(log);
            }
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnAdd.Name, "Item", Util.GetTime());
                db.insertLog(log);
            }
        }
    }
}
