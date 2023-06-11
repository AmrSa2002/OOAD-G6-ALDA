using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Identity;

namespace FlyAway.Models
{
    public class Korisnici
    {
        [Key]
        public int Id { get; set;}
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Slika { get; set; }
        public Korisnici(){}
    }
}
