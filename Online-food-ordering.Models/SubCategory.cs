using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class SubCategory
    {
        [Key]
        public int id { get; set; }
        public string title {  get; set; }

        public int categoryID {  get; set; }
        public Category category { get; set; }
        

    }
}
