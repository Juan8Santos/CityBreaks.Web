using CityBreaks.Web.Data.Models;
using CityBreaks.Web.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ICityService cityService;

    public IndexModel(ICityService cityService)
    {
        this.cityService = cityService;
    }

    public List<City> Cities { get; set; }

    public async Task OnGetAsync()
    {
        Cities = await this.cityService.GetAllAsync();
    }
}
