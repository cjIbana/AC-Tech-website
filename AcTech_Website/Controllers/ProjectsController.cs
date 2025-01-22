using Microsoft.AspNetCore.Mvc;

namespace Frank_Website.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult AcTechProjects()
        {

            string imagesFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets/Projects_Images");
            var images = Directory.EnumerateFiles(imagesFolderPath)
                                  .Select(Path.GetFileName) 
                                  .ToList();

            return View(images); 
        }
    }
}
