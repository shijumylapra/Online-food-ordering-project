using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string name {  get; set; }
        public string city { get; set; }
        public string address { get; set;}
        public string postalCode {  get; set; }

    }
}
