using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Online_Book_Store
{
    public partial class kullanıciprofil : Form
    {

        Customer cs = new Customer();
        public kullanıciprofil()
        {
            InitializeComponent();
        }
        public kullanıciprofil(Customer cs)
        {
            InitializeComponent();
            listBox1.Visible = false;
            ToolTip Aciklama = new ToolTip();
            Aciklama.SetToolTip(button1, "kaydet");
            this.cs = cs;
        }


        private void kullanıciprofil_Load(object sender, EventArgs e)
        {
            string a = cs.Username;
            DatabaseClass db = DatabaseClass.createConnection("onlineSales");
            DataTable tb = new DataTable();
            tb = db.getData("select * from CustomerInformationTable where customerNick='" + a +"'");
            if(tb.Rows.Count > 0)
            {
                label6.Text = tb.Rows[0][5].ToString();
                label7.Text = tb.Rows[0][4].ToString();
                label8.Text = tb.Rows[0][3].ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* DATADAN ALINAN BİLGİLER PARCALAR ADLI BİR DİZİYE ATILACAK*/

             

          /*  SaveFileDialog save = new SaveFileDialog();
            save.Filter = "TXT Dosyası|*.txt";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Kayit = new StreamWriter(save.FileName);
                int c = 0;
                for (int i = 0; i < parcalar.Length; i++)
                {
                    Kayit.Write(parcalar[i]);
                    Kayit.Write("\t");
                    c++;
                    if (c % 3 == 0)
                    {
                        Kayit.Write("\n");
                    }
                }

                Kayit.Close();
            }*/

        }

        private void gecmis_Click(object sender, EventArgs e)
        {
            if (listBox1.Visible)
                listBox1.Visible = false;

            else
            {
                listBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
