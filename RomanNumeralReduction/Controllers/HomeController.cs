using Microsoft.AspNetCore.Mvc;
using RomanNumeralReduction.Data;
using RomanNumeralReduction.Models;
using System.Diagnostics;

namespace RomanNumeralReduction.Controllers
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
            RomanNumeralData RomanNumeral = new();

            var calculateObj = 0;
            var objInput = "XLCD";

            var patternData = RomanNumeral.GetRomanNumeral().ToList();
            for (int i = 0; i < objInput.Length; i++)
            {
                var x = patternData.Where(_m => _m.RomanName.Equals(objInput[i].ToString())).FirstOrDefault();
                if (x is not null)
                {
                    calculateObj += x.RomanValue;
                }
            }

            var y = calculateObj / 2; 
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