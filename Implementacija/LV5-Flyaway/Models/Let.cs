using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LV5_Flyaway.Models
{
    public class Let
    {
        [Key]

        public int Id { get; set; }
        public int BrojAviona { get; set; }
        public int BrojSlobodnihMjesta { get; set; }
        public string Destinacija { get; set; }
        public double Cijena { get; set; }
        public DateTime Vrijeme_Polijetanja { get; set; }
        public DateTime Vrijeme_Slijetanja { get; set; }
        public DateTime Datum_Polaska { get; set; }
        public Let() { }

        public int zauzmiMjesto(int mjesto)
        {
            mjesto=(BrojSlobodnihMjesta-1);
            return mjesto;
        }
        public int oslobodiMjesto(int mjesto)
        {
            mjesto = (BrojSlobodnihMjesta + 1);
            return mjesto;

        }
    }
}
