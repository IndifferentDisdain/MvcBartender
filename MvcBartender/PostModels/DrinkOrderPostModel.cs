using System;
using System.Collections.Generic;
using System.Linq;
using MvcBartender.Models;

namespace MvcBartender.PostModels
{
    public class DrinkOrderPostModel
    {
        private readonly EntityFrameworkContext _dbContext = new EntityFrameworkContext();

        private DrinkOrderPostModel() { }

        public static int CreateDrinkOrder(IList<DrinkOrderItemPostModel> drinks)
        {
            var postModel = new DrinkOrderPostModel();
            var context = postModel._dbContext;
            var drinkIdsToAdd = drinks.Select(x => x.DrinkId);
            var drinksLookup = postModel._dbContext.Drinks.Where(x => drinkIdsToAdd.Contains(x.Id)).ToList();

            var drinkOrder = new DrinkOrder
            {
                OrderedOnUTC = DateTime.UtcNow,
                TotalPrice = 0.00m,
                IsComplete = false
            };

            context.DrinkOrders.Add(drinkOrder);
            context.SaveChanges();

            var drinkOrderItems = new List<DrinkOrderItem>();

            foreach (var drink in drinks)
            {
                var lookup = drinksLookup.FirstOrDefault(x => x.Id == drink.DrinkId);
                if (lookup == null)
                {
                    throw new NullReferenceException();
                }

                drinkOrderItems.Add(new DrinkOrderItem
                {
                    DrinkId = lookup.Id,
                    DrinkOrderId = drinkOrder.Id,
                    Quantity = drink.Quantity,
                    UnitPrice = lookup.Price
                });
            }

            drinkOrder.TotalPrice = drinkOrderItems.Sum(x => x.Quantity*x.UnitPrice);
            context.DrinkOrderItems.AddRange(drinkOrderItems);

            context.SaveChanges();

            return drinkOrder.Id;
        }
    }
}