using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using dotnetdodo.Models;

namespace dotnetdodo.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View(new OrderFormModel());
        }

[HttpPost]
public IActionResult Index(OrderFormModel formModel)
{
    // Get the stock item width
    int stockWidth = formModel.StockItemWidth;

    // Get the widths and demands entered by the user
    List<int> widths = formModel.Widths;
    List<int> demands = formModel.Demands;

    // Do something with the user input
    // ...

    return View(formModel);
}


        private List<List<int>> CutStock(List<int> stockSizes, List<int> demands)
        {
            // TODO: Implement the CutStock function to calculate the optimal patterns

            // This is just a placeholder return value for now
            return new List<List<int>>();
        }
    }
}
