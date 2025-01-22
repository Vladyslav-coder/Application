using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ExampleModel : PageModel
{
    [BindProperty]
    public double Number1 { get; set; }
    [BindProperty]
    public double Number2 { get; set; }
    [BindProperty]
    public string Operation { get; set; }
    public double? Result { get; private set; }

    public IActionResult OnPost()
    {
        Result = Operation switch
        {
            "add" => Number1 + Number2,
            "subtract" => Number1 - Number2,
            "multiply" => Number1 * Number2,
            "divide" => Number2 != 0 ? Number1 / Number2 : null,
            _ => null
        };

        ViewData["Result"] = Result;
        return Page();
    }
}
