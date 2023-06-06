using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlyAway.Models
{
    public class Let
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Avion")]
        public int BrojAviona { get; set; }
        public int BrojSlobodnihMjesta { get; set; }

        [ForeignKey("Destinacija")]
        public string Destinacija { get; set; }
        public double Cijena { get; set; }
        public DateTime Vrijeme_Polijetanja { get; set; }
        public DateTime Vrijeme_Slijetanja { get; set; }
        public DateTime Datum_Polaska { get; set; }
       
        [EnumDataType(typeof(TipLeta))]
        public TipLeta TipLeta { get; set; }
        public Let() { }
    }
}
