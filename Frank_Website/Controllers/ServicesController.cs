using Frank_Website.Reporsitory;
using Microsoft.AspNetCore.Mvc;

namespace Frank_Website.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IDataRepository _dataRepository;

        public ServicesController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<IActionResult> Services()
        {
            var data = await _dataRepository.GetCuisineDataAysync();
            return View(data);
        }
    }
}
