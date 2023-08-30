using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data;
using RazorPages.Models;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Pages.Category
{
    public class EditModel : PageModel
    {


        private readonly ApplicationDbContext _dbContext;

        public EditModel(ApplicationDbContext dbContext) { _dbContext = dbContext; }

        [BindProperty]
        public Categories? categoryobj { get; set; }
        public void OnGet(int id)
        {

            if (id != 0 && id != null)
            {
                // find id from primary key column.
                categoryobj = _dbContext.Categories.Find(id);
                // first or defualt
                //categoryobj = _dbContext.Categories.FirstOrDefault(u => u.Id == id);
                // uses the where condition and then first or default.
                //categoryobj = _dbContext.Categories.Where(u => u.Id == id).FirstOrDefault();
            }
        }

        public IActionResult OnPost()
        {
            if (categoryobj != null)
            {
                _dbContext.Categories.Update(categoryobj);
                _dbContext.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return Redirect("Index");

            }
            else
            {
                return Redirect("Error");
            }
        }

    }
}
