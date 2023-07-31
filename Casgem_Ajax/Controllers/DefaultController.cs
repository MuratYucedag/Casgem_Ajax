using Casgem_Ajax.DAL;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Casgem_Ajax.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerList()
        {
            var jsonCustomer = JsonConvert.SerializeObject(context.Customers.ToList());
            return Json(jsonCustomer);
        }
    }
}
