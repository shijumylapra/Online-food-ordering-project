using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Online_food_ordering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_food_ordering.Repository
{
    public class DbInitializer :IDbInitializer
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ApplicationDbContext context;

        public DbInitializer(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.context = context;
        }

        public void Initialize() 
        {
            try
            {
                if (context.Database.GetPendingMigrations().Count() > 0)
                {
                    context.Database.Migrate();
                }
            }
            catch (Exception)
            {

                throw;
            }
            if (context.Roles.Any(x => x.Name == "Admin"))return;
             roleManager.CreateAsync(new IdentityRole("Manager")).GetAwaiter().GetResult();
            roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            var _user = new ApplicationUser()
            {
                userName = "admin@yahoo.com",
                email = "admin@yahoo.com",
                name = "Shiju",
                city="Edmonton",
                address = "Hello EDM",
                postalCode = "TH24G5"
            };

            userManager.CreateAsync(_user,"Admin@123").GetAwaiter().GetResult();
            userManager.AddToRoleAsync(_user, "Admin");

        }
    }
}
