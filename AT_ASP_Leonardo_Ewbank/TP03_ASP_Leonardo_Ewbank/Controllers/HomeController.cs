using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP03_ASP_Leonardo_Ewbank.Models;
using TP03_ASP_Leonardo_Ewbank.Repository;

namespace TP03_ASP_Leonardo_Ewbank.Controllers
{
    public class HomeController : Controller
    {
       
        private AniversarianteRepository AniversarianteRepository { get; set; }
        public HomeController(AniversarianteRepository aniversarianteRepository)
        {
            this.AniversarianteRepository = aniversarianteRepository;
        }


        public IActionResult Index()
        {



            return View(AniversarianteRepository.ListarTodosPorData());
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
