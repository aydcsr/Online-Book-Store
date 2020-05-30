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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Customer cs = new Customer();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DatabaseClass db = DatabaseClass.createConnection("onlineSales");
            string str = "select * from CustomerInformationTable where customerNick='"+txtUsername.Text + "'and customerPassword='"+txtPassword.Text+"'";
            DataTable tb = new DataTable();
            tb = db.getData(str);
            if (tb.Rows.Count == 1)
            {
                cs.Firstname = tb.Rows[0][1].ToString();
                cs.Lastname = tb.Rows[0][2].ToString();
                MainForm mainform = new MainForm(cs);
            

                mainform.ShowDialog();

            }
            else
                MessageBox.Show("yanlıs");


        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Signup_Form signup = new Signup_Form();
            this.Hide();
            signup.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
