using MvcBartender.Models;

namespace MvcBartender.ViewModels
{
    public class DrinkOrderItemViewModel : Drink
    {
        public int Quantity { get; set; }
    }
}