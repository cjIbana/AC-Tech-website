using Frank_Website.Models;

namespace Frank_Website.Infrastructure.Reporsitory
{
    public interface IDataRepository
    {
        Task<List<AboutUsDataModel>> GetDataAsync();
    }
}
