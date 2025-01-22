using Frank_Website.Models;
using Frank_Website.Reporsitory;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Frank_Website.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataRepository _dataRepository;

        public AboutController(ILogger<HomeController> logger, IDataRepository dataRepository)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        public async Task<IActionResult> AboutAcTech()
        {
            var data = await _dataRepository.GetDataAsync();
            return View(data);
        }
    }
}