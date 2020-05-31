using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class Book : ItemInterface
    {
        String producttype;
        String name;
        String author;
        String publisher;
        String page;
        String type;
        String language;
        String price;
        String sale;

        public Book(string producttype, string name, string author, string publisher, string page, string type, string language, string price, string sale)
        {
            this.producttype = producttype;
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.page = page;
            this.type = type;
            this.language = language;
            this.price = price;
            this.sale = sale;
        }

        public string Name { get => name; set => name = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Page { get => page; set => page = value; }
        public string Type { get => type; set => type = value; }
        public string Language { get => language; set => language = value; }
        public string Price { get => price; set => price = value; }
        public string Sale { get => sale; set => sale = value; }
        public string Producttype { get => producttype; set => producttype = value; }

        public string getInfo()
        {
            string s;
            s = name + "," + author + "," + price + "," + page + "," + publisher;
            return s;
        }
    }
}
