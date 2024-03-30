using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Model;

namespace WebApp.Pages.Users;

public class NewModel : PageModel
{
    [BindProperty]
    public User NewUser { get; set; } = default!;
    public PageResult OnGet()
    {
        return Page();
    }

    public IActionResult OnPostAsync()
    {
        if (!ModelState.IsValid) return Page();
        return RedirectToPage();
    }
}
