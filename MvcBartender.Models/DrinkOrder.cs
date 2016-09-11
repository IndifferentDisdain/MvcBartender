using System;
using System.ComponentModel.DataAnnotations;

namespace MvcBartender.Models
{
    public class DrinkOrder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime OrderedOn { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public bool IsComplete { get; set; }
    }
}
