using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public void OnGet()
    {
    }

    public IActionResult OnPost(string customerName, string paperType, int width)
    {
        // TODO: Process the form data and save to the database
        return Page();
    }

  

}