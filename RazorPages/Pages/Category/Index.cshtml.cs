using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;
using RazorPages.Models;

namespace RazorPages.Pages.Category
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public List<Categories> categoryList = new List<Categories>();

        public IndexModel(ApplicationDbContext dbContext) { _dbContext = dbContext; }

        public void OnGet()
        {
            categoryList = _dbContext.Categories.ToList();
        }
    }
}
