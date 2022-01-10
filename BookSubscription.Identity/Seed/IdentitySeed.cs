using BookSubscription.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSubscription.Identity.Seed
{
    public class IdentitySeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {

            var Roles = new List<IdentityRole>()
            {
                new IdentityRole()
                {
                     Name = "Administrator"
                },

                new IdentityRole()
                {
                     Name = "Subscriber"
                },

                new IdentityRole()
                {
                    Name = "ThirdParty"
                }
            };

            foreach (var userRole in Roles)
            {
                var role = await roleManager.FindByNameAsync(userRole.Name);
                if (role != null)
                    continue;

                await roleManager.CreateAsync(userRole);
            }




            var applicationUser = new ApplicationUser
            {
                FirstName = "Chris",
                LastName = "Kimbi",
                Email = "chris@example.com",
                EmailConfirmed = true
            };



            var user = await userManager.FindByEmailAsync(applicationUser.Email);
            if (user == null)
            {
                var result = await userManager.CreateAsync(applicationUser, "songBirds10#$5");

                if (result.Succeeded)
                    await userManager.AddToRoleAsync(applicationUser, "Administrator");
            }



        }
    }
}
