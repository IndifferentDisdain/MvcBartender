using System.ComponentModel.DataAnnotations;
using MvcBartender.Models;

namespace MvcBartender.ViewModels
{
    public class DrinkOrderItemViewModel
    {
        public int DrinkId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        
        public int Quantity { get; set; }
    }
}