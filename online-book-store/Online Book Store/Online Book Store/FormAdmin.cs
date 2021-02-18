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
    public partial class FormAdmin : Form
    {
        private DatabaseClass db = DatabaseClass.createConnection("onlineSales");
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void novelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemAdd frmAdd = new FormItemAdd("BookTable", "novel");
            frmAdd.ShowDialog();
        }

        private void taleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemAdd frmAdd = new FormItemAdd("BookTable", "tale");
            frmAdd.ShowDialog();
        }

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemAdd frmAdd = new FormItemAdd("CdTable", "CD");
            frmAdd.ShowDialog();
        }

        private void magazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormItemAdd frmAdd = new FormItemAdd("MagazineTable", "magazine");
            frmAdd.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgwProducts.DataSource = db.getData("select * from BookTable");
        }

        private void cDsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgwProducts.DataSource = db.getData("select * from CdTable");
        }

        private void magazinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgwProducts.DataSource = db.getData("select * from MagazineTable");
        }

        private void FormAdmin_Activated(object sender, EventArgs e)
        {
            DataTable tb = db.getData("select * from ProductTable");
            dgwProducts.DataSource = tb;
        }

        private void dgwProducts_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            string productNo;
            if (e.Button == MouseButtons.Right)
            {
                int satir = dgwProducts.HitTest(e.X, e.Y).RowIndex;
                if (satir > -1)
                {
                    dgwProducts.Rows[satir].Selected = true;
                    if (dgwProducts.Rows[satir].Cells["productNo"].Value != null)
                    {
                        productNo = dgwProducts.Rows[satir].Cells["productNo"].Value.ToString();
                    }
                }
            }
        }

        private void dgwProducts_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwProducts.Rows[e.RowIndex].Cells["productTypeId"].Value.ToString() == "3")
            {
                FormBookUpdate frmBookUpdate = new FormBookUpdate(dgwProducts.Rows[e.RowIndex].Cells["productNo"].Value.ToString());
                frmBookUpdate.ShowDialog();
            }
            else if (dgwProducts.Rows[e.RowIndex].Cells["productTypeId"].Value.ToString() == "5")
            {
                FormMagazineUpdate frmMagazineUpdate = new FormMagazineUpdate(dgwProducts.Rows[e.RowIndex].Cells["productNo"].Value.ToString());
                frmMagazineUpdate.ShowDialog();
            }
            else if (dgwProducts.Rows[e.RowIndex].Cells["productTypeId"].Value.ToString() == "4")
            {
                FormCdUpdate frmCdUpdate = new FormCdUpdate(dgwProducts.Rows[e.RowIndex].Cells["productNo"].Value.ToString());
                frmCdUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid product type");
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
