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
        List<ItemInterface> listitems = new List<ItemInterface>();
        List<ItemInterface> books = new List<ItemInterface>();
        List<ItemInterface> cds = new List<ItemInterface>();
        List<ItemInterface> magazines = new List<ItemInterface>();
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
            DataTable tb = new DataTable();
            string column = "productAuthor,productPublisher,productPageSize,productType,productLanguage,visibility,productPrice,productSale,productName";
            tb = db.getData(column, "BookTable");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                Book b = new Book("3", tb.Rows[i][8].ToString(), tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString(), tb.Rows[i][2].ToString(), tb.Rows[i][3].ToString(), tb.Rows[i][4].ToString(), tb.Rows[i][6].ToString(), tb.Rows[i][7].ToString());
                listitems.Add(b);
            }
            column = "productSinger,visibility,productPrice,productSale,productName,typeOfSong";
            tb.Clear();
            tb = db.getData(column, "CdTable");
            for(int i = 0; i < tb.Rows.Count;i++)
            {
                CD c = new CD("4", tb.Rows[i][0].ToString(), tb.Rows[i][4].ToString(), tb.Rows[i][2].ToString(), tb.Rows[i][3].ToString(), tb.Rows[i][5].ToString());
                listitems.Add(c);
            }
            tb.Clear();
            column = "productIssue,visibility,productPrice,productSale,productName";
            tb = db.getData(column, "magazineTable");
            for(int i=0;i<tb.Rows.Count;i++)
            {
                Magazine m = new Magazine("5", tb.Rows[i][4].ToString(), tb.Rows[i][0].ToString(), tb.Rows[i][2].ToString(), tb.Rows[i][3].ToString());
                listitems.Add(m);
            }
            VirtualDesign();

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
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnClose.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if(LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnHide.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnSearch.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, btnBasket.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            FormBasket bsktform = new FormBasket();
            bsktform.Show();

        }

        private void VirtualDesign()
        {

            int i = 0;
            while(listitems[i].getType() == "3")
            {
                books.Add(listitems[i]);
                i++;
            }
            while (listitems[i].getType() == "4")
            {
                cds.Add(listitems[i]);
                i++;
            }
            while (listitems[i].getType() == "5")
            {
                magazines.Add(listitems[i]);
                i++;
                if (i == listitems.Count) { break; }
            }
            //ADD BOOKS
            bookname1.Text = books[0].getName();
            bookauthor1.Text = books[0].getOwner();
            bookprice1.Text = books[0].getPrice() + " TL";
            bookname2.Text = books[1].getName();
            bookauthor2.Text = books[1].getOwner();
            bookprice2.Text = books[1].getPrice() + " TL";
            bookname3.Text = books[2].getName();
            bookauthor3.Text = books[2].getOwner();
            bookprice3.Text = books[2].getPrice() + " TL";
            bookname4.Text = books[3].getName();
            bookauthor4.Text = books[3].getOwner();
            bookprice4.Text = books[3].getPrice() + " TL";
            bookname5.Text = books[4].getName();
            bookauthor5.Text = books[4].getOwner();
            bookprice5.Text = books[4].getPrice() + " TL";
            bookname6.Text = books[5].getName();
            bookauthor6.Text = books[5].getOwner();
            bookprice6.Text = books[5].getPrice() + " TL";
            bookname7.Text = books[6].getName();
            bookauthor7.Text = books[6].getOwner();
            bookprice7.Text = books[6].getPrice() + " TL";
            //ADD MAGAZINES
            magazinename1.Text = magazines[0].getName();
            issue1.Text = magazines[0].getOwner();
            magazineprice1.Text = magazines[0].getPrice() + " TL";
            magazinename2.Text = magazines[1].getName();
            issue2.Text = magazines[1].getOwner();
            magazineprice2.Text = magazines[1].getPrice() + " TL";
            magazinename3.Text = magazines[2].getName();
            issue3.Text = magazines[2].getOwner();
            magazineprice3.Text = magazines[2].getPrice() + " TL";
            magazinename4.Text = magazines[3].getName();
            issue4.Text = magazines[3].getOwner();
            magazineprice4.Text = magazines[3].getPrice() + " TL";
            magazinename5.Text = magazines[4].getName();
            issue5.Text = magazines[4].getOwner();
            magazineprice5.Text = magazines[4].getPrice() + " TL";
            magazinename6.Text = magazines[5].getName();
            issue6.Text = magazines[5].getOwner();
            magazineprice6.Text = magazines[5].getPrice() + " TL";
            magazinename7.Text = magazines[6].getName();
            issue7.Text = magazines[6].getOwner();
            magazineprice7.Text = magazines[6].getPrice() + " TL";
            //ADD CDS
            cdsinger1.Text = cds[0].getOwner();
            cdname1.Text = cds[0].getName();
            cdprice1.Text = cds[0].getPrice() + " TL";
            cdsinger2.Text = cds[1].getOwner();
            cdname2.Text = cds[1].getName();
            cdprice2.Text = cds[1].getPrice() + " TL";
            cdsinger3.Text = cds[2].getOwner();
            cdname3.Text = cds[2].getName();
            cdprice3.Text = cds[2].getPrice() + " TL";
            cdsinger4.Text = cds[3].getOwner();
            cdname4.Text = cds[3].getName();
            cdprice4.Text = cds[3].getPrice() + " TL";
            cdsinger5.Text = cds[4].getOwner();
            cdname5.Text = cds[4].getName();
            cdprice5.Text = cds[4].getPrice() + " TL";
            cdsinger6.Text = cds[5].getOwner();
            cdname6.Text = cds[5].getName();
            cdprice6.Text = cds[5].getPrice() + " TL";
            cdsinger7.Text = cds[6].getOwner();
            cdname7.Text = cds[6].getName();
            cdprice7.Text = cds[6].getPrice() + " TL";

        }
        //Panel Click Events started
        private void bookpanel1_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel1.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[0]);
            i.Show();
        }

        private void bookpanel2_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel2.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[1]);
            i.Show();
        }

        private void bookpanel3_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel3.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[2]);
            i.Show();
        }

        private void bookpanel4_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel4.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[3]);
            i.Show();
        }

        private void bookpanel5_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel5.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[4]);
            i.Show();
        }

        private void bookpanel6_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel6.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[5]);
            i.Show();
        }

        private void bookpanel7_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, bookpanel7.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(books[6]);
            i.Show();
        }

        private void magazinepanel1_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel1.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[0]);
            i.Show();
        }

        private void magazinepanel2_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel2.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[1]);
            i.Show();
        }

        private void magazinepanel3_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel3.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[2]);
            i.Show();
        }

        private void magazinepanel4_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel4.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[3]);
            i.Show();
        }

        private void magazinepanel5_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel5.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[4]);
            i.Show();
        }

        private void magazinepanel6_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel6.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[5]);
            i.Show();
        }

        private void magazinepanel7_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, magazinepanel7.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(magazines[6]);
            i.Show();
        }

        private void panelcd1_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd1.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[0]);
            i.Show();
        }

        private void panelcd2_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd2.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[1]);
            i.Show();
        }

        private void panelcd3_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd3.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[2]);
            i.Show();
        }

        private void panelcd4_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd4.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[3]);
            i.Show();
        }

        private void panelcd5_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd5.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[4]);
            i.Show();
        }

        private void panelcd6_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd6.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[5]);
            i.Show();
        }

        private void panelcd7_Click(object sender, EventArgs e)
        {
            if (LoginedCustomer.getInstance().Customer != null)
            {
                LogClass log = new LogClass(LoginedCustomer.getInstance().Customer.Id, panelcd7.Name, "MainForm", Util.GetTime());
                db.insertLog(log);
            }
            Item i = new Item(cds[6]);
            i.Show();
        }
        //Panel Click Events ended
    }
}
