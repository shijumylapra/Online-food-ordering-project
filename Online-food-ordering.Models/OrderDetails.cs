using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int orderHeadId {  get; set; }

        public OrderHead orderHead { get; set; }
        public int itemId { get; set; }
        public Item item { get; set; }
        public int count { get; set; }  
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }

    }
}
