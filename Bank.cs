using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal class Bank
    {
    }

    internal class Account : Bank
    {
        public string Name { get; set; }
    }

    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }


}
