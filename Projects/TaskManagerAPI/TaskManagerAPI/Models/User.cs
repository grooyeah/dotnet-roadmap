using Microsoft.AspNetCore.Identity;

namespace TaskManagerAPI.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; } = string.Empty;
    }
}
