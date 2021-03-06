﻿using System.Collections.Generic;
using System.Linq;
using MvcBartender.Models;

namespace MvcBartender.ViewModels
{
    public class DrinkOrderViewModel
    {
        private readonly EntityFrameworkContext _dbContext = new EntityFrameworkContext();

        private DrinkOrderViewModel()
        {
        }

        public static DrinkOrderViewModel Create()
        {
            var retVal = new DrinkOrderViewModel();

            retVal.Drinks = retVal._dbContext.Drinks.OrderBy(x => x.Id).Select(x => new DrinkOrderItemViewModel
            {
                DrinkId = x.Id,
                Name = x.Name,
                Price = x.Price,
                Quantity = 0
            }).ToList();

            return retVal;
        }

        public IList<DrinkOrderItemViewModel> Drinks { get; set; }
    }
}