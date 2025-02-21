using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public String Index()
        {
            return "This is my default action...";
        }
        //
        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encoding.Web;
        public String Welcome(String name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
