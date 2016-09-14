using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MvcBartender.PostModels;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IList<DrinkOrderItemPostModel> drinks)
        {
            if (!ModelState.IsValid) return View();

            var orderId = DrinkOrderPostModel.CreateDrinkOrder(drinks.Where(x => x.Quantity > 0).ToList());
            return RedirectToAction("Confirmation", new {id = orderId});
        }

        public ActionResult Confirmation(int id)
        {
            return View(DrinkOrderConfirmationViewModel.Create(id));
        }
    }
}