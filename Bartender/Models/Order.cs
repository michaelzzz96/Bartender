using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Bartender.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required]
        [Display(Name = "Beverage")]
        public CocktailName CocktailName { get; set; }

        [Required]
        [Display(Name = "Ordered By")]
        public string OrderedBy { get; set; }
    }


    public enum CocktailName
    {
        [Display(Name = "Beer")] Beer = 1,
        [Display(Name = "Wine")] Wine,
        [Display(Name = "Spirit")] Spirita,
        [Display(Name = "Whisky")] Whisky,
       
    }
}
