using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class Category
    {
        [Key]
            public int id { get; set; }

        [Required]
        public string title { get; set; }
        
    }
}
