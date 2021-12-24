using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMangerBlank
{
   public class CREDIT: PAYMENT
    {
        public int number { get; set; }
        public string type { get; set; }
        public int expDate { get; set; }

        public void authorized()
        {

        }
    }
}
