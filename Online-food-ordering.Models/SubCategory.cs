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
        public int Id { get; set; }
        public string Title {  get; set; }

        public int CategoryID {  get; set; }
        public Category Category { get; set; }
        

    }
}
