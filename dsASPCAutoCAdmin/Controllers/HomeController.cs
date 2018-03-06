using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dsASPCAutoCAdmin.Models;
using dsASPCAutoCAdmin.ViewModels;
using DevExtreme.AspNet.Mvc;
using Newtonsoft.Json;
using DevExtreme.AspNet.Data;

namespace dsASPCAutoCAdmin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var em = new MenuViewModel();
            ViewData["FilterMenu"] = em.menu;
            return View();
            
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Productos()
        {
            var em = new MenuViewModel();
            ViewData["FilterMenu"] = em.menu;
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public ActionResult GetData(DataSourceLoadOptions loadOptions)
        {
            return Content(JsonConvert.SerializeObject(DataSourceLoader.Load(SampleData.Companies, loadOptions)), "application/json");
        }
    }
}
