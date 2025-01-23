using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act01
{
    internal class petnames
    {
        public string pOwner { get; set; }
        public string pnames { get; set; }
        public string pGender{ get; set; }

        public override string ToString()
        {
            return pOwner + " " + pnames +  " " + pGender;
        }

    }
}
