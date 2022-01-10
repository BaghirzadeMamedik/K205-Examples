using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K205_Examples
{
    public class User  // public, protected, private, internal, protected internal
    {
        public int Id;
        public string Name;
        public string Surname;
        public string Password;



        public string Hash()
        {
            return Password;
        }
    }
}
