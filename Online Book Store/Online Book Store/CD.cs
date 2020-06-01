using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class CD : ItemInterface
    {
        String producttype;
        String singer;
        String name;
        String price;
        String sale;
        String type;

        public CD(string producttype, string singer, string name, string price, string sale, string type)
        {
            this.producttype = producttype;
            this.singer = singer;
            this.name = name;
            this.price = price;
            this.sale = sale;
            this.type = type;
        }

        public string Singer { get => singer; set => singer = value; }
        public string Name { get => name; set => name = value; }
        public string Price { get => price; set => price = value; }
        public string Sale { get => sale; set => sale = value; }
        public string Type { get => type; set => type = value; }
        public string Producttype { get => producttype; set => producttype = value; }

        public string getDetail1()
        {
            return type;
        }

        public string getDetail2()
        {
            return null;
        }

        public string getInfo()
        {
            string s;
            s = producttype + "," + name + "," + singer + "," + price + "," + type;
            return s;
        }

        public string getName()
        {
            return name;
        }

        public string getOwner()
        {
            return singer;
        }

        public string getPrice()
        {
            return price;
        }

        public string getType()
        {
            return Producttype;
        }
    }
}
