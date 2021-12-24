using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace OrderMangerBlank
{

    public class ORDER
    {
        SqlConnection baglan = new SqlConnection("Data Source=MSI;Initial Catalog=Pizza;Integrated Security=True");
        public  enum siparisdurumu
        {  
            siparisbeklemede,
            siparisalındı,
            siparisodendi
         }
        public DateTime date { get; set; }
        DateTime idate = DateTime.Now;
        public CUSTOMER CUSTOMER { get; set; }
        public ORDER_DETAIL orderdetail;
        public  siparisdurumu Status { get; set; }
        

        public void urunekle()
        {
            
        }

        public int calcTax()
        {
            ORDER_DETAIL urun = new ORDER_DETAIL();
            urun.TaxStatus = 5;
            return 5;
        }

        public int calcTotal(int Price)
        {
            int sontoplam;
            ORDER_DETAIL topla = new ORDER_DETAIL();
            sontoplam = topla.calcSubTotal(Price) + topla.TaxStatus;
            return sontoplam;
        }

        public void totalWeight(int ShippingWeight)
        {
            int totalweight;
            ORDER_DETAIL urun = new ORDER_DETAIL();
            urun.calcWeight(ShippingWeight);
            orderdetail = urun;

        }
    }
}
