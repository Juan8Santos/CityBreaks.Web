using CityBreaks.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CityBreaks.Web.Data.Models;
using Microsoft.EntityFrameworkCore;


namespace CityBreaks.Web.Pages
{
    public class CreatePropertyModel : PageModel
    {
        private readonly CityBreaksContext context;

        public CreatePropertyModel(CityBreaksContext context)
        {
            this.context = context;
        }

        [BindProperty]
        public Property Property { get; set; } = new Property();

        public SelectList Cities { get; set; }

        public async Task OnGetAsync()
        {
            var cities = await this.context.Cities.Include(x => x.Country).ToListAsync();

            Cities = new SelectList(cities, "Id", "Name");
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            await this.context.Properties.AddAsync(Property);
            await this.context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
