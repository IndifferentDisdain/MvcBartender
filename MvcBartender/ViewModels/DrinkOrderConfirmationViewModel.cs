using System;
using MvcBartender.Models;

namespace MvcBartender.ViewModels
{
    public class DrinkOrderConfirmationViewModel
    {
        private readonly EntityFrameworkContext _dbContext = new EntityFrameworkContext();

        public int OrderId { get; private set; }

        public string TotalPrice { get; private set; }

        private DrinkOrderConfirmationViewModel() { }

        public static DrinkOrderConfirmationViewModel Create(int orderId)
        {
            var vm = new DrinkOrderConfirmationViewModel();
            var drinkOrder = vm._dbContext.DrinkOrders.Find(orderId);
            if (drinkOrder == null)
            {
                throw new NullReferenceException("Could not find drink");
            }

            vm.OrderId = orderId;
            vm.TotalPrice = drinkOrder.TotalPrice.ToString("C");

            return vm;
        }
    }
}