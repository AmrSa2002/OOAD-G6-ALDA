using System.Collections.Generic;

namespace FlyAway.Models
{
    public class Putnik : Korisnici
    {
        public string Email { get; set; }

        public string Password { get; set; }
        public List<Rezervacija> Rezervacija {get; }
        public Putnik() { }
    }
}
