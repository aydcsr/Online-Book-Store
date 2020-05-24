using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Book_Store
{
    public class Customer
    {
        private String firstname;
        private String lastname;
        private String email;
        private String username;
        private String password;
        private String address;
        public Customer(string firstname, string lastname, string email, string username, string password, string address)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Address = address;
            
        }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
    }
}
