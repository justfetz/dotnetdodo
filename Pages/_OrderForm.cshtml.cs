
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
        public CuttingStockInput CuttingStockInput { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Create a new CuttingStockInput object and populate its properties
            CuttingStockInput = new CuttingStockInput();
            CuttingStockInput.StockLength = Convert.ToInt16(Request.Form["CuttingStockInput.StockItemWidth"]);
            string input = Request.Form["CuttingStockInput.Widths"];
            int[] widths = input.Split(',').Select(int.Parse).ToArray();

            CuttingStockInput.Widths = widths;
            string secinput = Request.Form["CuttingStockInput.Demands"];
            int[] demands = input.Split(',').Select(int.Parse).ToArray();
            CuttingStockInput.Demands = demands;

            // Pass the CuttingStockInput object to the CuttingStockSolver service to get the optimal patterns
            var patterns = CuttingStockSolver.Solve(CuttingStockInput.StockLength, CuttingStockInput.Widths, CuttingStockInput.Demands);

            // Write the optimal patterns to the console
            foreach (var pattern in patterns)
            {
                Console.WriteLine("Pattern: " + pattern);
              
            }

            return Page();
        }
    }
}
