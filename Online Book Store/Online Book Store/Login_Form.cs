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
    /// author Aydın CESUR
    /// </summary>
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                cs.Id = tb.Rows[0][0].ToString();
                cs.Firstname = tb.Rows[0][1].ToString();
                cs.Lastname = tb.Rows[0][2].ToString();
                cs.Address = tb.Rows[0][3].ToString();
                cs.Email = tb.Rows[0][4].ToString();
                cs.Username = tb.Rows[0][5].ToString();
                cs.Password = tb.Rows[0][6].ToString();
                cs.Authorization = tb.Rows[0][7].ToString();
                cs.Phonenumber = tb.Rows[0][8].ToString();
                LoginedCustomer.getInstance().Customer = cs;
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnLogin.Name, "Login_Form", Util.GetTime());
                db.insertLog(log);
                MainForm mainform = new MainForm(LoginedCustomer.getInstance().Customer);
                mainform.ShowDialog();

            }
            else
            {
                MessageBox.Show("Username or password incorrect");
            }



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
