using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBartender.ViewModels;

namespace MvcBartender.Controllers
{
    public class OrderDrinksController : Controller
    {
        // GET: OrderDrinks
        public ActionResult Index()
        {
            var vm = DrinkOrderViewModel.Create();
            return View(vm);
        }
    }
}