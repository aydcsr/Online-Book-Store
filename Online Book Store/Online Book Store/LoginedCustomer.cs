using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class LoginedCustomer
    {
        private Customer customer;
        private static LoginedCustomer loginedCustomer;

        public Customer Customer { get => customer; set => customer = value; }
        public static LoginedCustomer getInstance()
        {
            if(loginedCustomer == null)
            {
                loginedCustomer = new LoginedCustomer();
            }
            return loginedCustomer;
        }

    }
}
