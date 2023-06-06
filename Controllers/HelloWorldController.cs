using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ProjetoMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        //public string Index()
        {
            return View();
            //return "Apresenta esta mensagem";
        }

        public IActionResult Welcome(string nome, int numTimes = 10)
        {
            //return HtmlEncoder.Default.Encode($"Oi {nome}, ID: {ID}");
            //return "Estou no metodo Welcome do HelloWorldController";

            ViewData["Message"] = "Hello " + nome;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
