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
    public partial class FormBasket : Form
    {
        public FormBasket()
        {
            InitializeComponent();
        }

        private void FormBasket_Load(object sender, EventArgs e)
        {
            int totalcost = 0;
            Basket bskt = new Basket();
            if(bskt.basket != null)
            {
                for (int i = 0; i < bskt.basket.Count; i++)
                {
                    dataGridView1.Rows.Add(bskt.basket[i].getName(), bskt.basket[i].getOwner(), bskt.basket[i].getPrice());
                    totalcost += Int16.Parse(bskt.basket[i].getPrice());
                }
                lblPrice.Text = totalcost.ToString();
            }
        }
    }
}
