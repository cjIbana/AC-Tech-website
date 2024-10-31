using Frank_Website.Reporsitory;
using Microsoft.AspNetCore.Mvc;

namespace Frank_Website.Controllers
{
    public class CuisineController : Controller
    {
        private readonly IDataRepository _dataRepository;

        public CuisineController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<IActionResult> CuisineMenu()
        {
            var data = await _dataRepository.GetCuisineDataAysync();
            return View(data);
        }

        public IActionResult MenuLunch() {
            return View("Lunch");
        }

        public IActionResult MenuDinner()
        {
            return View("Dinner");
        }

        public IActionResult WineList()
        {
            return View("Wine");
        }
    }
}
