using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    class ItemFactory
    {
        ItemInterface GetItem(string type)
        {            
            if(type == "3") // Book
            {
               
            }
            else if (type == "4") // Cd
            {

            }
            else if (type == "5") // Magazine
            {

            }
            return null;
        }
    }
}
