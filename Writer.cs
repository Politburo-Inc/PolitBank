using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolitBank
{
    internal class Writer
    {
        public string FilePath { get; set; }

        public Writer(string filepath)
        {
            this.FilePath = filepath;
        }

        internal void saveUser(User user)
        {

        }

        internal void saveAccount()
        {

        }
    }
}
