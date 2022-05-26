using System.ComponentModel.DataAnnotations;

namespace dotnet_core_webapi_jwt.Models
{
    public class UserLogins
    {
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        public UserLogins() { }
    }
}
