using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using TheBlogProject.Enums;
using TheBlogProject.Models;

namespace TheBlogProject.Utilities
{
    public static class SeedHelper
    {
        public static async Task SeedDataAsync(UserManager<BlogUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRoles(roleManager);
            await SeedAdmin(userManager);
            await SeedModerator(userManager);
        }

        private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Moderator.ToString()));
        }

        private static async Task SeedAdmin(UserManager<BlogUser> userManager)
        {
            if (await userManager.FindByEmailAsync("david.deland1987@gmail.com") == null)
            {
                var admin = new BlogUser()
                {
                    Email = "david.deland1987@gmail.com",
                    UserName = "david.deland1987@gmail.com",
                    FirstName = "David",
                    LastName = "Deland",
                    DisplayName = "ddeland1",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(admin, "Abc&123!");
                await userManager.AddToRoleAsync(admin, Roles.Admin.ToString());
            }
        }

        private static async Task SeedModerator(UserManager<BlogUser> userManager)
        {
            if (await userManager.FindByEmailAsync("jaxholliday@gmail.com") == null)
            {
                var moderator = new BlogUser()
                {
                    Email = "jaxholliday@gmail.com",
                    UserName = "jaxholliday@gmail.com",
                    FirstName = "Andrew",
                    LastName = "Holliday",
                    DisplayName = "DrewMod",
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(moderator, "Abc&123!");
                await userManager.AddToRoleAsync(moderator, Roles.Admin.ToString());
            }

        }
    }
}
