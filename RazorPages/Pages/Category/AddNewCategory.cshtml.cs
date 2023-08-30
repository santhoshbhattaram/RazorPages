using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Category
{
    public class AddNewCategoryModel : PageModel
    {
        [BindProperty]
        public Categories Category { get; set; }

        private readonly ApplicationDbContext _dbContext;

        public AddNewCategoryModel(ApplicationDbContext dbContext) { _dbContext = dbContext; }

        public IActionResult OnPost()
        {

            _dbContext.Categories.Add(Category);
            _dbContext.SaveChanges();
            TempData["success"] = "Category created successfully";
            return Redirect("/Category/Index");

        }
    }
}
