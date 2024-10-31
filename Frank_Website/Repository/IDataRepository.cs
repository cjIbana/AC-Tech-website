using Frank_Website.Models;

namespace Frank_Website.Reporsitory
{
    public interface IDataRepository
    {
        Task<List<AboutUsDataModel>> GetDataAsync();
        Task<List<CuisineDataModel>> GetCuisineDataAysync();
    }
}
