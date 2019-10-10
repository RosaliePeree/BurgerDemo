using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Utilities
{
    public static class PolicyUtility
    {
        public const string CanAdministerUsers = "CanAdministerUsers";
        public const string CanAdministerMenus = "CanAdministerMenus";
        public const string CanAdministerPictures = "CanAdministerPictures";
        public const string CanAdministerRestaurants = "CanAdministerRestaurants";
        public const string CanAdministerScores = "CanAdministerScores";

        public const string CanReadUsers = "CanReadUsers";
        public const string CanReadMenus = "CanReadMenus";
        public const string CanReadPictures = "CanReadPictures";
        public const string CanReadRestaurants = "CanReadRestaurants";
        public const string CanReadScores = "CanReadScores";

        public const string CanUpdateMenus = "CanUpdateMenus";
        public const string CanUpdateRestaurants = "CanUpdateRestaurants";

        public const string CanCreatePictures = "CanCreatePictures";
        public const string CanCreateScores = "CanCreateScores";


        public static void ConfigServicePolicies(this IServiceCollection services)
        {
            services.AddAuthorization(option =>
            {
                /* Policies is requiring all claims. */

                option.AddPolicy(CanAdministerUsers, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimUser.Create);
                    policy.RequireClaim(ClaimType.Permission, ClaimUser.Delete);
                    policy.RequireClaim(ClaimType.Permission, ClaimUser.Update);
                    policy.RequireClaim(ClaimType.Permission, ClaimUser.Read);
                });

                option.AddPolicy(CanAdministerMenus, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimMenu.Create);
                    policy.RequireClaim(ClaimType.Permission, ClaimMenu.Delete);
                    policy.RequireClaim(ClaimType.Permission, ClaimMenu.Update);
                    policy.RequireClaim(ClaimType.Permission, ClaimMenu.Read);
                });

                option.AddPolicy(CanAdministerPictures, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimPicture.Create);
                    policy.RequireClaim(ClaimType.Permission, ClaimPicture.Delete);
                    policy.RequireClaim(ClaimType.Permission, ClaimPicture.Update);
                    policy.RequireClaim(ClaimType.Permission, ClaimPicture.Read);
                });

                option.AddPolicy(CanAdministerRestaurants, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimRestaurant.Create);
                    policy.RequireClaim(ClaimType.Permission, ClaimRestaurant.Delete);
                    policy.RequireClaim(ClaimType.Permission, ClaimRestaurant.Update);
                    policy.RequireClaim(ClaimType.Permission, ClaimRestaurant.Read);
                });

                option.AddPolicy(CanAdministerScores, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimScore.Create);
                    policy.RequireClaim(ClaimType.Permission, ClaimScore.Delete);
                    policy.RequireClaim(ClaimType.Permission, ClaimScore.Update);
                    policy.RequireClaim(ClaimType.Permission, ClaimScore.Read);
                });

                option.AddPolicy(CanReadUsers, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimUser.Read);
                });

                option.AddPolicy(CanReadMenus, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimMenu.Read);
                });

                option.AddPolicy(CanReadPictures, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimPicture.Read);
                });

                option.AddPolicy(CanReadRestaurants, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimRestaurant.Read);
                });

                option.AddPolicy(CanReadScores, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimScore.Read);
                });




                option.AddPolicy(CanUpdateMenus, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimMenu.Update);
                });

                option.AddPolicy(CanUpdateRestaurants, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimRestaurant.Update);
                });



                option.AddPolicy(CanCreatePictures, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimPicture.Create);
                });

                option.AddPolicy(CanCreateScores, policy =>
                {
                    policy.RequireClaim(ClaimType.Permission, ClaimScore.Create);
                });

            });
        }
    }
}
