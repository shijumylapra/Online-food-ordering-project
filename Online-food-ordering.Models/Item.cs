using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class Item
    {
        public int id { get; set; }public string Title { get; set; }
       
        public string description { get; set; }
        public double price { get; set; }
        public int categoryID { get; set; }
        public Category category { get; set; }

        public int subCategoryID { get; set; }
        public SubCategory subCategory { get; set; }


    }
}
