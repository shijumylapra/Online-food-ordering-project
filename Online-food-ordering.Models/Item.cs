using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class Item
    {
        public int Id { get; set; }public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public int SubCategoryID { get; set; }
        public SubCategory SubCategory { get; set; }


    }
}
