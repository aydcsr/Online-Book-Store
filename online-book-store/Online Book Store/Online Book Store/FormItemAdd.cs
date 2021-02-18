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
    public partial class FormItemAdd : Form
    {
        string tableName;
        string itemTypeName;
        private DatabaseClass db = DatabaseClass.createConnection("onlineSales");
        public FormItemAdd()
        {
            InitializeComponent();
        }
        public FormItemAdd(string tableName, string itemTypeName)
        {
            InitializeComponent();
            this.tableName = tableName;
            this.itemTypeName = itemTypeName;
            showGroupBox();
        }

        private void btnMagazineAdd_Click(object sender, EventArgs e)
        {
            int visibility = 0;
            if (rbMagazineVisibility.Checked == true)
                visibility = 1;
            DataTable tb = new DataTable();
            tb = db.getData("select productId from ProductTable where productTypeName='" + itemTypeName + "'");
            int id = Convert.ToInt32(tb.Rows[0][0]);
            string str = id + ",'" + tbMagazineIssiue.Text + "'," + visibility + ",'" + tbMagazinePrice.Text + "','" + tbMagazineSale.Text + "','" + tbMagazineName.Text + "'";
            db.insertData(tableName, "ProductTypeId,productIssue,visibility,productPrice,ProductSale,productName", str);
            this.Close();
        }
        private void showGroupBox()
        {
            if (tableName == "BookTable")
            {
                gbBook.Visible = true;
                Point p = new Point();
                p.X = this.Location.X + 100;
                p.Y = this.Location.Y + 100;
                gbBook.Location = p;
            }
            else if (tableName == "MagazineTable")
            {
                gbMagazine.Visible = true;
                Point p = new Point();
                p.X = this.Location.X + 100;
                p.Y = this.Location.Y + 100;
                gbMagazine.Location = p;
            }
            else if (tableName == "CdTable")
            {
                gbCd.Visible = true;
                Point p = new Point();
                p.X = this.Location.X + 100;
                p.Y = this.Location.Y + 100;
                gbCd.Location = p;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = db.getData("select productId from ProductTable where productTypeName='book'");
            int id = Convert.ToInt32(tb.Rows[0][0]);
            int visibility = 0;
            if (rbVisibility.Checked == true)
                visibility = 1;
            string str = id + ",'" + tbBookAuthor.Text + "','" + tbPublisher.Text + "','" + tbPageCount.Text + "','" + itemTypeName + "','" + tbLangugage.Text + "'," + visibility + ",'" + tbPrice.Text + "','" + tbSale.Text + "','" + tbBookName.Text + "'";
            db.insertData(tableName, "productTypeId,productAuthor,productPublisher,productPageSize,productType,productLanguage,visibility,productPrice,productSale,productName", str);
            this.Close();
        }

        private void btnCdAdd_Click(object sender, EventArgs e)
        {
            int visibility = 0;
            if (rbMagazineVisibility.Checked == true)
                visibility = 1;
            DataTable tb = new DataTable();
            tb = db.getData("select productId from ProductTable where productTypeName='" + itemTypeName + "'");
            int id = Convert.ToInt32(tb.Rows[0][0]);
            string str = id + ",'" + tbMagazineIssiue.Text + "'," + visibility + ",'" + tbMagazinePrice.Text + "','" + tbMagazineSale.Text + "','" + tbMagazineName.Text + "'";
            db.insertData(tableName, "ProductTypeId,productIssue,visibility,productPrice,ProductSale,productName", str);
            this.Close();
        }
    }
}
