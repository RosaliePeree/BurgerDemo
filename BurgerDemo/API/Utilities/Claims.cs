using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Utilities
{
    public static class ClaimType
    {
        public const string Permission = "Permission";
    }
    public static class ClaimUser
    {
        public const string Create = "CreateUser";
        public const string Delete = "DeleteUser";
        public const string Read = "ReadUser";
        public const string Update = "UpdateUser";
    }
    
    public static class ClaimMenu
    {
        public const string Create = "CreateMenu";
        public const string Delete = "DeleteMenu";
        public const string Read = "ReadMenu";
        public const string Update = "UpdateMenu";
    }
    
    public static class ClaimPicture
    {
        public const string Create = "CreatePicture";
        public const string Delete = "DeletePicture";
        public const string Read = "ReadPicture";
        public const string Update = "UpdatePicture";
    }

    public static class ClaimRestaurant
    {
        public const string Create = "CreateRestaurant";
        public const string Delete = "DeleteRestaurant";
        public const string Read = "ReadRestaurant";
        public const string Update = "UpdateRestaurant";
    }

    public static class ClaimScore
    {
        public const string Create = "CreateScore";
        public const string Delete = "DeleteScore";
        public const string Read = "ReadScore";
        public const string Update = "UpdateScore";
    }
}
