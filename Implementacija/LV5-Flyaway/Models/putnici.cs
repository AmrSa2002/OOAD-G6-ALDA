using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LV5_Flyaway.Models
{
    public class putnici
    {
        [Key]

        public int Id { get; set; }

        [ForeignKey("Let")]
        public int IdLeta{get; set;}

        public Let Let { get; set; }
        public putnici() { }


    }
}
