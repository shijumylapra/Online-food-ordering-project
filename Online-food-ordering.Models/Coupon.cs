using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class Coupon
    {
        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }

        public double discount { get; set; }
        public double minAmount  { get; set; }

        public byte[] couponPicture { get; set; }
        public bool isActive { get; set; }

         
    }
    public enum CouponType
    {
        Percent=0,
        Currency=1
    }
}
