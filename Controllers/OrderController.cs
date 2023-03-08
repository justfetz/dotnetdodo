using Microsoft.AspNetCore.Mvc;
using dotnetdodo.Models.Order;


namespace dotnetdodo.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OrderModel order)
        {
            // Do something with the order data
            // You can access the data using the order object that's passed in
            
            return RedirectToAction("Index");
        }
    }
}
