using Microsoft.AspNetCore.Identity;

namespace doktorblog.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {
            
        }
        public ApplicationRole(string rolename,string description)
        {
            this.Description = description;
        }
    }
}
