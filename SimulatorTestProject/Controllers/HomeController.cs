using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SimulatorTestProject.Models;
using SimulatorTestProject.ViewModel;

namespace SimulatorTestProject.Controllers
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
            PipeViewModel model = new PipeViewModel();
            VentilViewModel ventil = new VentilViewModel();

            AllItemViewModel all = new AllItemViewModel();
            return View(all);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult TogglePipePump(int Id)
        {
            AllItemViewModel a = new AllItemViewModel();
            foreach (PumpClass pu in a.AllItemPump)
            {
                if (pu.Id == Id)
                {
                    switch (pu.Status)
                    {
                        case 1:
                            pu.Status = 2;
                            break;
                        case 2:
                            pu.Status = 1;
                            break;
                    }

                    foreach (PipeClass p in pu.PumpPipeList)
                    {
                        switch (p.Status)
                        {
                            case 1:
                                p.Status = 2;
                                break;
                            case 2:
                                p.Status = 1;
                                break;
                        }
                        break;
                    }
                    break;

                }
            }

            string output = JsonConvert.SerializeObject(a.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
            return RedirectToAction("Index");
        }

        public ActionResult ToggleVentil(int Id)
        {
            AllItemViewModel a = new AllItemViewModel();
            foreach (VentilClass v in a.AllItemVentil)
            {
                if (v.Id == Id)
                {
                    switch (v.Status)
                    {
                        case 1:
                            v.Status = 2;
                            break;
                        case 2:
                            v.Status = 1;
                            break;
                    }

                    foreach (PipeClass p in v.VentilPipeList)
                    {
                        switch (p.Status)
                        {
                            case 1:
                                p.Status = 2;
                                break;
                            case 2:
                                p.Status = 1;
                                break;
                        }
                        break;
                    }
                    break;

                }
            }

            string output = JsonConvert.SerializeObject(a.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
            return RedirectToAction("Index");
        }

        public ActionResult TogglePipe(int Id)
        {
            AllItemViewModel a = new AllItemViewModel();
            foreach(VentilClass v in a.AllItemVentil)
            {
                if(v.Id == Id)
                {
                    foreach (PipeClass q in v.VentilPipeList)
                    {
                        switch (q.Status)
                        {
                            case 1:
                                q.Status = 2;
                                break;
                            case 2:
                                q.Status = 1;
                                break;
                        }
                        break;
                    }
                }
            }
            string output = JsonConvert.SerializeObject(a.AllItemVentil, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText("DAL/VentilJSON.json", output);
            return RedirectToAction("Index");
        }
        public IActionResult Details()
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
