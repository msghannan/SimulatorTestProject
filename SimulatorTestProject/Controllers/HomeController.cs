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

        //public ActionResult TogglePipe(int Id)
        //{
        //    PipeViewModel model = new PipeViewModel();
        //    foreach (PipeClass p in model.PipeList)
        //    {
        //        if (p.Id == Id)
        //        {
        //            switch (p.Status)
        //            {
        //                case 1:
        //                    p.Status = 2;
        //                    break;
        //                case 2:
        //                    p.Status = 1;
        //                    break;
        //            }
        //            break;
        //        }
        //    }

        //    string output = JsonConvert.SerializeObject(model.PipeList, Newtonsoft.Json.Formatting.Indented);
        //    System.IO.File.WriteAllText("DAL/json.json", output);
        //    return RedirectToAction("Index");
        //}

        public ActionResult ToggleVentil(int Id)
        {
            AllItemViewModel a = new AllItemViewModel();
            foreach (VentilClass p in a.AllItemVentil)
            {
                if (p.Id == Id)
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

                    foreach (PipeClass q in p.VentilPipeList)
                    {
                        switch (q.Status)
                        {
                            case 1:
                                q.Status = 2;
                                q.ImageSrc = q.ImageSrcGreen;
                                break;
                            case 2:
                                q.Status = 1;
                                q.ImageSrcGreen = q.ImageSrc;
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
