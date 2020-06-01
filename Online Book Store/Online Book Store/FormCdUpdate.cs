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
    /// <summary>
    /// author Sumeyye Busra KARTAL
    /// </summary>
    public partial class FormCdUpdate : Form
    {
        string productNo;
        DatabaseClass db = DatabaseClass.createConnection("onlineSales");
        public FormCdUpdate()
        {
            InitializeComponent();
        }
        public FormCdUpdate(string data)
        {
            InitializeComponent();
            productNo = data;
            setData();
        }
        private void FormCdUpdate_Load(object sender, EventArgs e)
        {

        }
        private void btnCdAdd_Click(object sender, EventArgs e)
        {
            int visibility = 0;
            if (rbCdVisibility.Checked == true)
                visibility = 1;
            string columns = "productSinger,visibility,productPrice,productSale,productName,typeOfSong";
            string values = "'" + tbCdSinger.Text + "'," + visibility + ",'" + tbCdPrice.Text + "','" + tbCdSale.Text + "','" + tbCdName.Text + "','" + tbSongType.Text + "'";
            db.updateData("CdTable", columns, values, "productNo=" + productNo);
            this.Close();
        }
        private void setData()
        {
            DataTable tb = new DataTable();
            tb = db.getData("select * from cdTable where productNo=" + productNo);
            tbCdSinger.Text = tb.Rows[0][1].ToString();
            tbCdPrice.Text = tb.Rows[0][3].ToString();
            tbCdSale.Text = tb.Rows[0][4].ToString();
            tbCdName.Text = tb.Rows[0][5].ToString();
            tbSongType.Text = tb.Rows[0][7].ToString();
            if (tb.Rows[0][2].ToString() == "1")
                rbCdVisibility.Checked = true;
        }

        private void btnCdDelete_Click(object sender, EventArgs e)
        {
            db.deleteData("cdTable", "productNo=" + productNo);
            this.Close();
        }
    }
}
