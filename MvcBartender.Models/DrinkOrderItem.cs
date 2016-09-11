using System.ComponentModel.DataAnnotations;

namespace MvcBartender.Models
{
    public class DrinkOrderItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DrinkOrderId { get; set; }

        [Required]
        public int DrinkId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Display(Name = "Price")]
        public decimal UnitPrice { get; set; }
    }
}
