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

        MachineClass machineClass = new MachineClass();

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

        public IActionResult JsonInfo()
        {
            AllItemViewModel all = new AllItemViewModel();
            return View(all);
        }

        public ActionResult TogglePump1(int id)
        {
            machineClass.TogglePump1(id);
            return RedirectToAction("Index");
        }

        public ActionResult ToggleVentil1(int id)
        {
            machineClass.ToggleVentil1(id);
            return RedirectToAction("Index");
        }

        public ActionResult ToggleVentil4(int id)
        {
            machineClass.ToggleVentil4(id);
            return RedirectToAction("Index");
        }

        public ActionResult ToggleVentil2(int id)
        {
            machineClass.ToggleVentil2(id);
            return RedirectToAction("Index");
        }

        public ActionResult ToggleVentil3(int id)
        {
            machineClass.ToggleVentil3(id);
            return RedirectToAction("Index");
        }

        public ActionResult ToggleVentil5(int id)
        {
            machineClass.ToggleVentil5(id);
            return RedirectToAction("Index");
        }
        //public ActionResult EmptyTank(int id)
        //{
        //    machineClass.EmptyTank(id);
        //    return RedirectToAction("Index");
        //}
        public ActionResult ReadyForFillMethod(int id)
        {
            machineClass.ReadyForFillMethod(id);
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
        public IActionResult DetailsVentil(int id)
        {
            var webClient = new WebClient();
            var jsonFile = webClient.DownloadString(@"DAL\VentilJSON.json");
            var dataFromJson = JsonConvert.DeserializeObject<List<VentilClass>>(jsonFile).Where(j => j.Id == id);

            return View(dataFromJson);
        }

        public IActionResult DetailsPump(int id)
        {
            var webClient = new WebClient();
            var jsonFile = webClient.DownloadString(@"DAL\PumpJSON.json");
            var dataFromJson = JsonConvert.DeserializeObject<List<PumpClass>>(jsonFile).Where(j => j.Id == id);

            return View(dataFromJson);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
