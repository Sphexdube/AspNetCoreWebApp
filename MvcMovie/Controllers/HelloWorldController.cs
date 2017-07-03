using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index() {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes) {
            ViewData["name"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }

    }
}
