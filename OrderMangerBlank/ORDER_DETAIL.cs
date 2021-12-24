using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMangerBlank
{
  public  class ORDER_DETAIL
    {
        public int Quantity { get; set; }
        public ITEM ITEM { get; set; }
        private int tax;
        public int TaxStatus
        {
            get{ return tax;   }
            set { tax = 5;    }      
        }
        
        public ORDER_DETAIL ()
        {

        }

        public ORDER_DETAIL(int quantity,  int taxstatus, ITEM item )
        {
            Quantity = quantity;
            TaxStatus = taxstatus;
            ITEM = item;
              
        }
        public void urunekle()
        {
            ORDER_DETAIL urunumuz = new ORDER_DETAIL();
            ITEM.catogory c = urunumuz.ITEM.description;
            int p= urunumuz.ITEM.Price;
            int w =urunumuz.ITEM.ShippingWeight;
            int s=urunumuz.Quantity;
            
        }

        public int calcSubTotal(int Price)
        {
            int toplam;
            ITEM urun = new ITEM();
            urun.getPriceForQuantity(Price);
            ITEM = urun;
            toplam=urun.getPriceForQuantity(Price )* Quantity;
            return toplam;
        }

        public int calcWeight(int ShippingWeight)
       {
            int weight;
            ITEM urun = new ITEM();
            weight = urun.ShippingWeight * Quantity;
            return weight;
                
        }
    }
}
