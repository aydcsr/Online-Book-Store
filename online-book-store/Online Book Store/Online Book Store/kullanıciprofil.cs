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
        DatabaseClass db = DatabaseClass.createConnection("onlineSales");
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
            button4.Visible = false;
            button3.Visible = false;
        }


        private void kullanıciprofil_Load(object sender, EventArgs e)
        {
            string a = cs.Username;
            
            DataTable tb = new DataTable();
            tb = db.getData("select * from CustomerInformationTable where customerNick='" + a +"'");
            if(tb.Rows.Count > 0)
            {
                label6.Text = tb.Rows[0][5].ToString();
                mailbox.Text = tb.Rows[0][4].ToString();
                adressbox.Text = tb.Rows[0][3].ToString();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, button1.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
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
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, gecmis.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, button2.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
            button4.Visible = true;
            button3.Visible = true;
            passwordc.Visible = true;
            passwordcb.Visible = true;
            mailbox.ReadOnly = false;
            adressbox.ReadOnly = false;
            updatep.Visible = true;

         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, button3.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
            if (!Util.isValidEmail(mailbox.Text))
             {
                lblErrorm.Visible = true;
                lblErrorm.Text = "Email is not valid";
                lblErrorm.ForeColor = Color.Red;
               
             }
            else
            {
                DatabaseClass db = DatabaseClass.createConnection("onlineSales");
                db.updateData("CustomerInformationTable", "customerEmail", "'" + mailbox.Text + "'", " customerNick=" + "'" + cs.Username + "'");
                mailbox.ReadOnly = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, button4.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
            db.updateData("CustomerInformationTable", "customerAdress", "'" + adressbox.Text + "'", " customerNick=" + "'" + cs.Username + "'");
            adressbox.ReadOnly = true;
        }

        private void passwordcb_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, passwordcb.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
            if (passwordc.Text.Length > 16 || passwordc.Text.Length < 8)
            {
                labeleror.Text = "Password length must be between 8 - 16";
                labeleror.ForeColor = Color.Red;
               
            }
            else
            {
                DatabaseClass db = DatabaseClass.createConnection("onlineSales");
                db.updateData("CustomerInformationTable", "customerPassword", "'" + passwordc.Text + "'", " customerNick=" + "'" + cs.Username + "'");
            }


        }

        private void updatep_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnClose.Name, "kullanıciprofil", Util.GetTime());
            db.insertLog(log);
            this.Hide();
        }
    }
}
