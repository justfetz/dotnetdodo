using Microsoft.AspNetCore.Mvc.RazorPages;

using System.Collections.Generic;
using System.Linq;

namespace dotnetdodo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly CuttingStockSolver _cuttingStockSolver;

        public IndexModel(CuttingStockSolver cuttingStockSolver)
        {
            _cuttingStockSolver = cuttingStockSolver;
        }

        public void OnGet()
        {

        }

        public void OnPost()
        {
    
        }
    }
}
