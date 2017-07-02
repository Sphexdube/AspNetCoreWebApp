using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index() {
            return View();
        }

        //public string Index() {
        //    return "This is my default action...";
        //}

        //GET: /HelloWorld/Welcome/
        public string Welcome() {
            return "This is the Welcome action method";
        }

        public string Data(string name, int numTimes = 1 ) {
            return HtmlEncoder.Default.Encode($"Hello {name}, numTimes is: {numTimes}");
        }

        public string MoreData(string name, int ID = 1) {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }

    }
}
