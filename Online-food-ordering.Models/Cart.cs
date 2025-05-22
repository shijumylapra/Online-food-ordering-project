using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class Cart
    {
        [Key]
        public int id { get; set; }
        public int itemid { get; set; }
        public Item item { get; set; }
        public string applicationUserID { get; set; }
        public ApplicationUser applicationUser { get; set; }
        [Required,MinLength(1)]
        public int count { get; set; }


    }
}
