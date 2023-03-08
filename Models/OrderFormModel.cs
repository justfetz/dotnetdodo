using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetdodo.Models
{
public class OrderFormModel : PageModel
{


    public List<int> Widths { get; set; }
    public List<int> Demands { get; set; }
    public int StockItemWidth { get; set; }
     public List<string> Inputs { get; set; } = new List<string>();

public async Task<IActionResult> OnPostAsync(ModelStateDictionary ModelState)
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    // add the user inputs to the Inputs list in the OrderFormModel
    Inputs.Add($"Width: {Widths}, Demand: {Demands}");

    return Page();
}
    
}

}
