using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Category
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public Categories? categoryobj { get; set; }

        private readonly ApplicationDbContext _dbContext;

        public DeleteModel(ApplicationDbContext dbContext) { _dbContext = dbContext; }
        public void OnGet(int id)
        {
            if (id != 0 && id != 0)
            {
               categoryobj = _dbContext.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            if (categoryobj != null)
            {
                Categories? obj = _dbContext.Categories.Find(categoryobj.Id);
                if (obj != null)
                {
                    _dbContext.Categories.Remove(obj);
                    _dbContext.SaveChanges();
                }
            }
            else
            {
                return NotFound();
            }
            TempData["success"] = "Category deleted successfully";
            return Redirect("/Category/Index");
        }
    }
}
