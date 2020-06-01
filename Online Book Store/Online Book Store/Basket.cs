using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class Basket
    {
        public List<ItemInterface> basket = new List<ItemInterface>();

        public void Additem(ItemInterface item)
        {
            basket.Add(item);
        }

    }
}
