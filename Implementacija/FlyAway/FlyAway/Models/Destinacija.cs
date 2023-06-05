using System.ComponentModel.DataAnnotations;

namespace FlyAway.Models
{
    public class Destinacija
    {
        [Key]
        public int Id { get; set; }
        public string Naziv { get; set; }

        public Destinacija() { }

    }
}
