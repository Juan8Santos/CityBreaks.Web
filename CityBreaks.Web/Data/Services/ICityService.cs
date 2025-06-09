using CityBreaks.Web.Data.Models;

namespace CityBreaks.Web.Data.Services
{
    public interface ICityService
    {
        Task<List<City>> GetAllAsync();

        Task<City> GetByNameAsync(string name);
    }
}
