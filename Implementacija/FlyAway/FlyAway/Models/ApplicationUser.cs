using Microsoft.AspNetCore.Identity;

namespace FlyAway.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string UserNamee { get; set; }
        public string Slika { get; set; }
    }
}
