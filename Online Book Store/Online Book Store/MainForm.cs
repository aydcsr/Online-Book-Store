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
            List<ItemInterface> listitems = new List<ItemInterface>();
            //////////////////////////////////////////////////////////
            ///    Data Tabledan veriler çekilip liste atılacak    ///
            //////////////////////////////////////////////////////////    
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
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, lblUsername.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
                kullanıciprofil kullanıciprofil = new kullanıciprofil(LoginedCustomer.getInstance().Customer);
                kullanıciprofil.ShowDialog();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnClose.Name, "MainForm", Util.GetTime());
            db.insertLog(log);
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnHide.Name, "MainForm", Util.GetTime());
            db.insertLog(log);
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnAdmin.Name, "MainForm", Util.GetTime());
            db.insertLog(log);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnSearch.Name, "MainForm", Util.GetTime());
            db.insertLog(log);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnCart.Name, "MainForm", Util.GetTime());
            db.insertLog(log);
        }
    }
}
