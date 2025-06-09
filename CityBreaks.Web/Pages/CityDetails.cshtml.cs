using CityBreaks.Web.Data.Models;
using CityBreaks.Web.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web.Pages
{
    public class CityDetailsModel : PageModel
    {
        private readonly ICityService cityService;

        public CityDetailsModel(ICityService cityService)
        {
            this.cityService = cityService;
        }

        public City City { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            City = await this.cityService.GetByNameAsync(name);

            return Page();
        }
    }
}
