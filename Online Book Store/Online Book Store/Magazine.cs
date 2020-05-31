using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class Magazine : ItemInterface
    {
        String producttype;
        String name;
        String issue;
        String price;
        String sale;

        public Magazine(string producttype, string name, string issue, string price, string sale)
        {
            this.producttype = producttype;
            this.name = name;
            this.issue = issue;
            this.price = price;
            this.sale = sale;
        }

        public string Producttype { get => producttype; set => producttype = value; }
        public string Name { get => name; set => name = value; }
        public string Issue { get => issue; set => issue = value; }
        public string Price { get => price; set => price = value; }
        public string Sale { get => sale; set => sale = value; }

        public string getInfo()
        {
            string s;
            s = producttype + "," + name + "," + issue + "," + price;
            return s;
        }
    }
}
