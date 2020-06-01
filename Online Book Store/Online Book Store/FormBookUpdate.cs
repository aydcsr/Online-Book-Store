using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    /// <summary>
    /// author Sumeyye Busra KARTAL
    /// </summary>
    public partial class FormBookUpdate : Form
    {
        string productNo;
        DatabaseClass db = DatabaseClass.createConnection("onlineSales");
        public FormBookUpdate()
        {
            InitializeComponent();
        }
        public FormBookUpdate(string data)
        {
            InitializeComponent();
            productNo = data;
            setData();
        }
        private void setData()
        {
            if (Convert.ToInt32(productNo) > 0)
            {
                DataTable tb = new DataTable();
                tb = db.getData("select * from BookTable where productNo=" + productNo);
                tbBookAuthor.Text = tb.Rows[0][1].ToString();
                tbPublisher.Text= tb.Rows[0][2].ToString();
                tbPageCount.Text= tb.Rows[0][3].ToString();
                tbBookType.Text = tb.Rows[0][4].ToString();
                tbLangugage.Text= tb.Rows[0][5].ToString();
                tbPrice.Text= tb.Rows[0][7].ToString();
                tbSale.Text= tb.Rows[0][8].ToString();
                tbBookName.Text= tb.Rows[0][9].ToString();
                if (tb.Rows[0][6].ToString() == "1")
                    rbVisibility.Checked = true;

            }
        }

        private void FormBookUpdate_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int visibility = 0;
            if (rbVisibility.Checked == true)
                visibility = 1;
            string values ="'"+tbBookAuthor.Text+"','"+tbPublisher.Text + "','" +tbPageCount.Text + "','" +tbBookType.Text + "','" +tbLangugage.Text + "',"+ visibility+",'"+tbPrice.Text + "','" +tbSale.Text + "','" +tbBookName.Text+"'";
            string column = "productAuthor,productPublisher,productPageSize,productType,productLanguage,visibility,productPrice,productSale,productName";
            db.updateData("BookTable", column, values, " productNo=" + productNo);
            this.Close();
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            db.deleteData("bookTable", "productNo=" + productNo);
            this.Close();
        }
    }
}
