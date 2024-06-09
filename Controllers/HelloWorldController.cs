using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MoviesMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/ Reemplazar el método index:

        public string Index()
        {
            return "This is my default action...";
        }
        //
        // GET: /HelloWorld/Welcome/ Agregar este método:

        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
