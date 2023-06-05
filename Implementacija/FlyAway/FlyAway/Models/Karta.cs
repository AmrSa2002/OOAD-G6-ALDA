using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyAway.Models
{
    public class Karta
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Putnik")]
        public int PutnikId{ get; set; }

        [ForeignKey("Let")]
        public int LetId { get; set; }


        public int BrojKreditneKartice { get; set; }
        public NacinPlacanja NacinPlacanja { get; set; }
        public Karta() { }

    }
}
