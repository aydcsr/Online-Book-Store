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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /////////////////////////////////////////////
            //Database den custumer bilgilerine bakılıp//
            //Eşleşen kullanıcı varsa giriş yapılacak  //
            //Yoksa hata mesajı gösterilip yeniden  gi-//
            //rilmesi beklenecek.......................//
            /////////////////////////////////////////////
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            Signup_Form signup = new Signup_Form();
            this.Hide();
            signup.Show();
        }
    }
}
