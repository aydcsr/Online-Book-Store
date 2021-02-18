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
    public partial class FormMagazineUpdate : Form
    {
        string productId;
        DatabaseClass db = DatabaseClass.createConnection("onlineSales");
        public FormMagazineUpdate()
        {
            InitializeComponent();
        }
        public FormMagazineUpdate(string data)
        {
            InitializeComponent();
            productId = data;
            setData();
        }
        private void FormMagazineUpdate_Load(object sender, EventArgs e)
        {

        }
        private void setData()
        {
            int visibility = 0;
            DataTable tb = new DataTable();
            tb=db.getData("select * from MagazineTable where productNo=" + productId);
            tbMagazineIssiue.Text = tb.Rows[0][1].ToString();
            tbMagazinePrice.Text = tb.Rows[0][3].ToString();
            tbMagazineSale.Text = tb.Rows[0][4].ToString();
            tbMagazineName.Text = tb.Rows[0][5].ToString();
            if (tb.Rows[0][2].ToString() == "1")
                rbMagazineVisibility.Checked = true;

        }
        private void btnMagazineAdd_Click(object sender, EventArgs e)
        {
            int visibility = 0;
            if (rbMagazineVisibility.Checked == true)
                visibility = 1;
            string column = "productIssue,visibility,productPrice,productSale,productName";
            string values = "'" + tbMagazineIssiue.Text + "'," + visibility + ",'" + tbMagazinePrice.Text + "','" + tbMagazineSale.Text + "','" + tbMagazineName.Text + "'";
            db.updateData("MagazineTable", column, values, "productNo=" + productId);
            this.Close();
        }

        private void btnMagazineDelete_Click(object sender, EventArgs e)
        {
            db.deleteData("magazineTable", "productNo=" + productId);
            this.Close();
        }
    }
}
