using GoodDoc_BackEnd.Data;
using GoodDoc_BackEnd.ViewModels.SearchViewModels;
using Microsoft.EntityFrameworkCore;

namespace GoodDoc_BackEnd.Services.GetService
{
    public class GetSearchService : IGetSearchService
    {
        private readonly GoodDocDbContext _context;

        public GetSearchService(GoodDocDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RegionViewModel>> GetRegionAsync()
        {
            return await _context.Regions.Select(x => new RegionViewModel
            {
                Name = x.Name,
                Id = x.Id,
            }).ToListAsync();
        }

        public async Task<IEnumerable<SpecialtyViewModel>> GetSpecialtyAsync()
        {
            return await _context.Specialties.Select(x => new SpecialtyViewModel
            {
                Name = x.Name,
                Id = x.Id,
            }).ToListAsync();
        }
    }
}