using Microsoft.AspNetCore.Mvc;

namespace Frank_Website.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult ReservationDetails()
        {
            return View("Reservation");
        }

        public IActionResult PrivateDining()
        {
            return View("PrivateDining");
        }
    }
}
