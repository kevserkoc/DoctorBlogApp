using Microsoft.AspNetCore.Identity;

namespace doktorblog.Identity
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
