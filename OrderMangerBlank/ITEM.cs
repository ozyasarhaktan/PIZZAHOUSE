using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMangerBlank
{

    
    public class ITEM
    {   public enum catogory
        {
            pizza,
            hamburger,
            icecek,
            patates
        }
        public int ShippingWeight { get; set; }
        public string pname { get; set; }
        public int Price { get; set; }
        public catogory description { get; set; }


        public ITEM()
        {

        }
            

        public ITEM(int  shippingWeight ,string pname )
        {
            this.ShippingWeight = shippingWeight;
            this.pname = pname;
            
        }

        
        public int getPriceForQuantity(int price)
        {
            this.Price = price;
            return (int)Price;
        }

    public float GetWeight(int shippingWeight)
        {
            this.ShippingWeight = shippingWeight;
            return (int)ShippingWeight;
        }


        
        
    }
}
