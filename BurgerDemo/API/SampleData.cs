using BurgerDemo.Model.Identity.Data;
using BurgerDemo.Model.Identity.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BurgerDemo
{
    public class SampleData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            var configuration = serviceProvider.GetRequiredService<IConfiguration>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            
            var context = serviceProvider.GetService<ApplicationDbContext>();

            string[] rolesAdmin = new string[] { "Admin", "Restaurant", "User" };
            string[] rolesRestaurant = new string[] { "Restaurant" };
            string[] rolesUser = new string[] { "User" };
            foreach (string role in rolesAdmin)
            {
                if (!context.Roles.Any(r => r.Name == role))
                {
                    await roleManager.CreateAsync(new ApplicationRole(role));
                }
            }

            foreach (string role in rolesRestaurant)
            {
                if (!context.Roles.Any(r => r.Name == role))
                {
                    await roleManager.CreateAsync(new ApplicationRole(role));
                }
            }

            foreach (string role in rolesUser)
            {
                if (!context.Roles.Any(r => r.Name == role))
                {
                    await roleManager.CreateAsync(new ApplicationRole(role));
                }
            }

            var userRestaurantOwner = new ApplicationUser
            {
                UserName = "Restaurant",
                Email = "xx@example.com"
            };

            var userUser = new ApplicationUser
            {
                Email = "xxxrx@example.com",
                UserName = "User"
            };

            var userAdmin = new ApplicationUser
            {
                Email = "admi@test.dk",
                UserName = "Admin"
            };


            if (!context.Users.Any(u => u.UserName == userAdmin.UserName))
            {
                var result = await userManager.CreateAsync(userAdmin, "5a25DD13-8bd6-43dd-9e17-06c4d1d3a710");
                await AssignRoles(serviceProvider, userAdmin.Email, rolesAdmin);

            }

            if (!context.Users.Any(u => u.UserName == userUser.UserName))
            { 
                var result = await userManager.CreateAsync(userUser, "2c56A143-41f8-42eb-8c8b-9cef5ab9b621");
                await AssignRoles(serviceProvider, userUser.Email, rolesUser);

            }

            if (!context.Users.Any(u => u.UserName == userRestaurantOwner.UserName))
            {
                var result = await userManager.CreateAsync(userRestaurantOwner, "f8fb001C-85fd-48f1-bb3e-f5585839dbb0");
                await AssignRoles(serviceProvider, userRestaurantOwner.Email, rolesRestaurant);
            }
            await context.SaveChangesAsync();
        }

        public static async Task<IdentityResult> AssignRoles(IServiceProvider services, string email, string[] roles)
        {
            UserManager<ApplicationUser> _userManager = services.GetService<UserManager<ApplicationUser>>();
            ApplicationUser user = await _userManager.FindByEmailAsync(email);
            var result = await _userManager.AddToRolesAsync(user, roles);

            return result;
        }

    }
}
