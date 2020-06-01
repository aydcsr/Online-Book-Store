using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public interface ItemInterface
    {
        string getInfo();
        string getName();
        string getPrice();
        string getOwner();
        string getDetail1();
        string getDetail2();
        string getType();
    }
}
