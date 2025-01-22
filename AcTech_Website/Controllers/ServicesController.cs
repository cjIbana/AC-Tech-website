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

        public IActionResult AcTechServices()
        {
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", "Products_Images");

            string[] imageFiles = Directory.GetFiles(folderPath)
                                    .Select(file => Path.GetFileName(file)) // Extract file names only
                                    .ToArray();

            // Pass the image file names to the view
            return View(imageFiles);
        }
    }
}
