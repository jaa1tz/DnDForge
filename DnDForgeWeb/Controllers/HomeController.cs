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
            return View("Login", vm);
        }

        public IActionResult Register(RegisterViewModel vm)
        {
            return View("Register", vm);
        }

        public IActionResult CreateCharacter(CreateCharacterViewModel vm)
        {
            return View("CreateCharacter", vm);
        }

        public IActionResult BasicData(BasicDataViewModel vm)
        {
            if (Request.Method == "GET")
                return View("BasicData", vm);
            return RedirectToAction("AbilityScores", vm);
        }

        public IActionResult AbilityScores(AbilityScoresViewModel vm)
        {
            return View("AbilityScores", vm);
        }

        public IActionResult StandardArray(StandardArrayViewModel vm) 
        {
            if (Request.Method == "GET")
                return View("StandardArray", vm);
            
            if (vm.Strength < 8)
            {
                vm.ErrorMessage = "Set a vaild number for Strength.";
                return View("StandardArray", vm);
            }

            if (vm.Dexterity < 8)
            {
                vm.ErrorMessage = "Set a vaild number for Dexterity.";
                return View("StandardArray", vm);
            }

            if (vm.Constitution < 8)
            {
                vm.ErrorMessage = "Set a vaild number for Constitution.";
                return View("StandardArray", vm);
            }

            if (vm.Intelligence < 8)
            {
                vm.ErrorMessage = "Set a vaild number for Intelligence.";
                return View("StandardArray", vm);
            }

            if (vm.Wisdom < 8)
            {
                vm.ErrorMessage = "Set a vaild number for Wisdom.";
                return View("StandardArray", vm);
            }

            if (vm.Charisma < 8)
            {
                vm.ErrorMessage = "Set a vaild number for Charisma.";
                return View("StandardArray", vm);
            }

            // do more checks



            // put data in database

            // Go to next page
            return RedirectToAction("Index");
        }

        public IActionResult PointBuy(PointBuyViewModel vm) 
        {
            if (Request.Method == "GET")
                return View("PointBuy", vm);
            return RedirectToAction("Index", vm);
        }

        public IActionResult RollDice(RollDiceViewModel vm) 
        {
            if (Request.Method == "GET")
                return View("RollDice", vm);
            return RedirectToAction("Index", vm);
        }

        public IActionResult Custom(CustomViewModel vm) 
        {
            if (Request.Method == "GET")
                return View("Custom", vm);
            return RedirectToAction("Index", vm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}