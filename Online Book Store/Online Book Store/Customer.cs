using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Online_Book_Store
{
    /// <summary>
    /// author Aydın CESUR
    /// </summary>
    public class Customer
    {
        private String firstname;
        private String lastname;
        private String email;
        private String username;
        private String password;
        private String address;
        private String phonenumber;
        private String authorization;
        private String id;
        public Customer()
        {
         
        }
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
        public string Phonenumber { get => phonenumber; set => phonenumber = value; }
        public string Authorization { get => authorization; set => authorization = value; }
        public string Id { get => id; set => id = value; }

        public string DatabaseValues()
        {
            string values;
            values = "'" + this.firstname + "','" + this.lastname + "','" + this.address + "','" + this.email + "','" + this.username + "','" + this.password+ "','0','"+this.phonenumber+ "','"+this.authorization+"'";
            return values;
        }
    }
}
