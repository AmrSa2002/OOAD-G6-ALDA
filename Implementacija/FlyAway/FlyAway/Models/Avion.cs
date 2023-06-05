using System.ComponentModel.DataAnnotations;

namespace FlyAway.Models
{
    public class Avion
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }

        public Avion() { }
    }
}
