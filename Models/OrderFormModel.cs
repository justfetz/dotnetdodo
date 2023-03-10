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

public IActionResult OnPostAsync()
{
    if (!ModelState.IsValid)
    {
        return Page();
    }

    // Add the user inputs to the Inputs list in the OrderFormModel
    Inputs.Add($"Width: {Widths}, Demand: {Demands}");

    // Construct a string that contains the input values
    var inputValues = string.Join("<br>", Inputs);

    // Return the input values as a string to the AJAX request
    return new JsonResult(new { inputsHtml = inputValues });
}



    }

}
