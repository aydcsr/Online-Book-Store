using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Book_Store
{
    public partial class Signup_Form : Form
    {
        public Signup_Form()
        {
            InitializeComponent();
        }
        public bool isValidProfile()
        {
            if(txtFirstName.Text == "" || txtLastName .Text == "")
            {
                lblError.Text = "Name part cannot be empty.";
                lblError.ForeColor = Color.Red;
                return false;
            }
            else if(!Util.isValidEmail(txtEmail.Text))
            {
                lblError.Text = "Email is not valid";
                lblError.ForeColor = Color.Red;
                return false;
            }
            ///////////////////////////////////
            //Username eşleşmesi denetlenecek//
            ///////////////////////////////////
            else if(txtPassword.Text.Length > 16 || txtPassword.Text.Length < 8)
            {
                lblError.Text = "Password length must be between 8 - 16";
                lblError.ForeColor = Color.Red;
                return false;
            }
            else if(txtPassword.Text != txtConfirm.Text)
            {
                lblError.Text = "Password is not matched";
                lblError.ForeColor = Color.Red;
                return false;
            }
            else
            {
                lblError.Text = "SignUp success";
                lblError.ForeColor = Color.Green;
                return true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(isValidProfile())
            {
                string password = Util.ComputeSha256Hash(txtPassword.Text); // Şifreler hash kodlarıyla tutulacak 
                Customer customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtUsername.Text, password, rtxtAddress.Text);
                //////////////////////////////////////////////////
                ///Oluşturulan customer database e eklenecek//////
                //////////////////////////////////////////////////
            }
            else
            {

            }
        }
        // Move Form
        int Move;
        int Mouse_X;
        int Mouse_Y;
        private void Signup_Form_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void Signup_Form_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void Signup_Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login_Form login_form = new Login_Form();
            login_form.Show();
            this.Close();
        }
        // End of move form
    }
}
