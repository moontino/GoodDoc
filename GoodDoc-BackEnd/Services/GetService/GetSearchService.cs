using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoodDoc_BackEnd.Data;
using GoodDoc_BackEnd.Models;
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

        public async Task<List<SpecialtyViewModel>> GetSpecialtyAsync()
        {

            try
            {
                return await _context.Specialties.Select(x => new SpecialtyViewModel
                {
                    Name = x.Name,
                    Id = x.Id,
                }).ToListAsync();
            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}