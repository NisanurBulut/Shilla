using Microsoft.AspNetCore.Identity;


namespace MagicShilla_Utility.Entity
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } 
    }
}
