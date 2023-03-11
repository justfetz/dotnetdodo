
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetdodo.Pages
{
    public class _OrderFormModel : PageModel
    {
        private readonly CuttingStockSolver _cuttingStockSolver;

        public _OrderFormModel(CuttingStockSolver cuttingStockSolver)
        {
            _cuttingStockSolver = cuttingStockSolver;
        }

        [BindProperty]
        public int StockItemWidth { get; set; }

        [BindProperty]
        public string Widths { get; set; }

        [BindProperty]
        public string Demands { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Console.WriteLine($"StockItemWidth: {StockItemWidth}");
            Console.WriteLine($"Widths: {Widths}");
            Console.WriteLine($"Demands: {Demands}");
            List<int> widthsList = Widths.Split(",").Select(int.Parse).ToList();
            List<int> demandsList = Demands.Split(",").Select(int.Parse).ToList();

            CuttingStockInput cuttingStockInput = new CuttingStockInput
            {
                
                Widths = widthsList.ToArray(),
                Demands = demandsList.ToArray(),
                StockLength= StockItemWidth
            };

            var results = CuttingStockSolver.Solve(cuttingStockInput.StockLength, cuttingStockInput.Widths, cuttingStockInput.Demands);
            Console.WriteLine($"Results: {string.Join(",", results)}");

            return Page();
        }
    }
}

