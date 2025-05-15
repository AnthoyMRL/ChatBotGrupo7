using System.Diagnostics;
using System.Threading.Tasks;
using ChatBotGrupo7.Models;
using ChatBotGrupo7.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChatBotGrupo7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            GeminiRepository repo = new GeminiRepository();
            string response = await repo.GetChatbotResponse("Dame un resumen de 100 palabras de la pelicula Titanic");

            ViewBag.chatbotAnswer = response;

            return View();

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
