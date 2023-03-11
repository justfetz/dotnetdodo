using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetdodo.Pages
{
    public class OrderFormModel : PageModel
    {
        public List<int> Widths { get; set; }
        public List<int> Demands { get; set; }
        public int StockItemWidth { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            string widthsString = Request.Form["widths"];
            string demandsString = Request.Form["demands"];
            string stockItemWidthString = Request.Form["stockItemWidth"];

            if (string.IsNullOrEmpty(widthsString) || string.IsNullOrEmpty(demandsString) || string.IsNullOrEmpty(stockItemWidthString))
            {
                return Page();
            }

            List<int> widths = widthsString.Split(",").Select(int.Parse).ToList();
            List<int> demands = demandsString.Split(",").Select(int.Parse).ToList();
            int stockItemWidth = int.Parse(stockItemWidthString);

            int[] intArray = (int[])widths.ToArray();   
            int[] demandArray = (int[])demands.ToArray();
            Widths = widths;
            Demands = demands;
            StockItemWidth = stockItemWidth;
            var solver = new CuttingStockSolver();


    // call the Solve method on the CuttingStockSolver with the user inputs
            var patterns = CuttingStockSolver.Solve(stockItemWidth, intArray, demandArray);

    // pass the patterns to the view using ViewData
            ViewData["Patterns"] = patterns;
            return Page();
        }
    }
}
