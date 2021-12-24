using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMangerBlank
{
   public class CUSTOMER
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public CUSTOMER()
        {

        }

        public CUSTOMER(string name , string address)
        {
            Name = name;
            Address = address;
        }


    }
}
