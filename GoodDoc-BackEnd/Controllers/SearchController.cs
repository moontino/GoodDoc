using GoodDoc_BackEnd.Services.GetService;
using GoodDoc_BackEnd.ViewModels.SearchViewModels;
using Microsoft.AspNetCore.Mvc;
using GoodDoc_BackEnd.Data;
using Microsoft.EntityFrameworkCore;

namespace GoodDoc_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly IGetSearchService _getSearchService;
        public SearchController(IGetSearchService getSearchService)
        {
            _getSearchService = getSearchService;
        }

        [HttpGet("specialty")]
        public async Task<IActionResult> GetSpecialty()
        {
            var data = await _getSearchService.GetSpecialtyAsync();
            if (data == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No data in database");
            }
            return StatusCode(StatusCodes.Status200OK, data);
        }

        [HttpGet("region")]
        public async Task<IActionResult> GetRegion()
        {
            var data = await _getSearchService.GetRegionAsync();
            if (data == null)
            {
                return StatusCode(StatusCodes.Status204NoContent, "No data in database");
            }
            return StatusCode(StatusCodes.Status200OK, data);
        }
    }
}