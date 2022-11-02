using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Recruits.Model;

namespace Recruits.Pages.Categories;
[BindProperties]

public class EditModel : PageModel
{
    private readonly ApplicationDbContext _db;
    public Category Category { get; set; }

    public EditModel(ApplicationDbContext db)
    {
        _db = db;
    }
    public void OnGet(int id)
    {
        Category = _db.Category.Find(id);
    }

    public async Task<IActionResult> OnPost()
    {
        if (ModelState.IsValid)
        {
            _db.Category.Update(Category);
            await _db.SaveChangesAsync();
            TempData["success"] = "Запись отредактирована";
            return RedirectToPage("Index");
        }
        return Page();
    }
}

