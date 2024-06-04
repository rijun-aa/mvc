using day21.Models;
using Microsoft.AspNetCore.Mvc;

namespace day21.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult GetCustomerDetails(int Id)
        {
            OderRepo oderRepo = new OderRepo();
            Customer custDetails = oderRepo.GetCustomerById(Id);
            return Json(custDetails);
        }

    }
}
