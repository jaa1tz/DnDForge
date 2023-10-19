using DnDForgeWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DnDForgeWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult LoginPost(LoginViewModel vm)
        {
            return View("Login");
        }

        public IActionResult Register(RegisterViewModel vm)
        {
            return View("Register");
        }

        public IActionResult CreateCharacter(CreateCharacterViewModel vm)
        {
            return View("CreateCharacter");
        }

        public IActionResult BasicData(BasicDataViewModel vm)
        {
            return View("BasicData");
        }

        public IActionResult AbilityScores(AbilityScoresViewModel vm)
        {
            return View("AbilityScores");
        }

        public IActionResult StandardArray(StandardArrayViewModel vm) 
        {
            return View("StandardArray");
        }

        public IActionResult PointBuy(PointBuyViewModel vm) 
        {
            return View("PointBuy");
        }

        public IActionResult RollDice(RollDiceViewModel vm) 
        {
            return View("RollDice");
        }

        public IActionResult Custom(CustomViewModel vm) 
        {
            return View("Custom");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}