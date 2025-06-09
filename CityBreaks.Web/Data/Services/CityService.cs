using CityBreaks.Web.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Data.Services
{
    public class CityService : ICityService
    {
        private readonly CityBreaksContext contextService;


        public CityService(CityBreaksContext contextService)
        {
            this.contextService = contextService;
        }

        public async Task<List<City>> GetAllAsync()
        {
            return await this.contextService.Cities.Include(x => x.Country).Include(x => x.Properties).ToListAsync();
        }

        public async Task<City?> GetByNameAsync(string name)
        {
            return await this.contextService.Cities.Include(x => x.Country).Include(x => x.Properties).FirstOrDefaultAsync(x => EF.Functions.Collate(x.Name, "NOCASE") == name);
        }
    }
}
