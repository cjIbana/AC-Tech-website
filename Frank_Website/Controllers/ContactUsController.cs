using Frank_Website.Reporsitory;
using Microsoft.AspNetCore.Mvc;

namespace Frank_Website.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly IDataRepository _dataRepository;

        public ContactUsController(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }
    }
}
