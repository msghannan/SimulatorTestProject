using SimulatorTestProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.ViewModel
{
    public class AllItemViewModel
    {
        public List<VentilClass> AllItemVentil { get; set; }
        public List<PipeClass> AllItemPipe { get; set; }

        public AllItemViewModel()
        {
            string jsonVentil = File.ReadAllText("DAL/VentilJSON.json");
            AllItemVentil = Newtonsoft.Json.JsonConvert.DeserializeObject<List<VentilClass>>(jsonVentil);
            string jsonPipe = File.ReadAllText("DAL/PipeJSON.json");
            AllItemPipe = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PipeClass>>(jsonPipe);
        }
    }
}
