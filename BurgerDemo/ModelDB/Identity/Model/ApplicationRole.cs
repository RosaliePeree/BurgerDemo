

using Microsoft.AspNetCore.Identity;


namespace BurgerDemo.Model.Identity.Model
{
    public class ApplicationRole : IdentityRole<long>
    {
        public ApplicationRole() : base()
        { }
        public ApplicationRole(string roleName) : base(roleName)
        {

        }
    }
}
