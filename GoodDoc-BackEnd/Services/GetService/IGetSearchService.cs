using GoodDoc_BackEnd.Models;
using GoodDoc_BackEnd.ViewModels.SearchViewModels;

namespace GoodDoc_BackEnd.Services.GetService
{
    public interface IGetSearchService
    {
        Task<List<SpecialtyViewModel>> GetSpecialtyAsync();
    }
}