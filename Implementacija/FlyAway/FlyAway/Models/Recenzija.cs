using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyAway.Models
{
    public class Recenzija
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Putnik")]
        public int UserId { get; set; }
        [ForeignKey("Let")]
        public int LetId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        public DateTime CommentDate { get; set; }
        public Recenzija() { }

    }
}
