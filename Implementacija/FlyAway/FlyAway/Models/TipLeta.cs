using System.ComponentModel.DataAnnotations;

namespace FlyAway.Models
{
    public enum TipLeta
    {
        [Display(Name = "Redovni")]
        Redovni,
        [Display(Name = "Vandredni")]
        Vandredni
    }
}
