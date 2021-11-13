using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        public User(string name, string password, int age, DateTime dateOfBirth)
        {
            this.Username = name;
            this.Password = password;
            this.Age = age;
            this.DateOfBirth = dateOfBirth;
        }
    }

}
