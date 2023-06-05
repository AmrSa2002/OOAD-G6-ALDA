using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FlyAway.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Putnik")]
        public int IdPutnika { get; set; }
        public Putnik Putnik { get; set; }

        [ForeignKey("Let")]
        public int IdLeta { get; set; }
        public Let Let { get; set; }

        public Rezervacija() { }
    }
}
