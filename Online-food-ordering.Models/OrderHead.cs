using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class OrderHead
    {

        public int Id { get; set; }
        public string applicationUserId { get; set; }
        public ApplicationUser applicationUser { get; set; }
        [DataType(DataType.Date)]
        public DateTime orderDate { get; set; }
        public DateTime pickupTime { get; set; }
        public DateTime pickupDate { get; set; }
        public double subTotal  { get; set; }
        public double orderTotal { get; set; }
        public string couponCode { get; set; }
        public double cuponDiscount { get; set; }
        public string transId   { get; set; }
        public string orderStatus { get; set; }
        public string paymentStatus { get; set; }
        public string name { get; set; }
        public string phone { get; set; }




    }
}
