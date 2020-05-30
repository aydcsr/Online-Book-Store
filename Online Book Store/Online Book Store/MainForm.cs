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
    public partial class MainForm : Form
    {
        DatabaseClass db = DatabaseClass.createConnection("onlineSales");
        public MainForm()
        {
            InitializeComponent();
        }

        int Move;
        int Mouse_X;
        int Mouse_Y;
        Customer cs = new Customer();
        public MainForm(Customer cs)
        {
            DataTable tb = db.getData("select * from customerInformationTable where customerNick = '" + cs.Username +"'");
            if(tb.Rows.Count >0)
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
            }
            InitializeComponent();
            if (cs.Authorization == "1")
            {
                btnAdmin.Visible = true;
            }
            lblUsername.Text = cs.Username;
            this.cs = cs;
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {


        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            if(lblUsername.Text == "Guess")
            {
                Login_Form lf = new Login_Form();
                lf.Show();
                this.Hide();
            }
            else
            {
                kullanıciprofil kullanıciprofil = new kullanıciprofil(cs);
                kullanıciprofil.ShowDialog();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dd.MM.yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss ");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
