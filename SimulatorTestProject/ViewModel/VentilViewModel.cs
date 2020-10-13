using SimulatorTestProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.ViewModel
{
    public class VentilViewModel
    {
        public List<VentilClass> VentilList { get; set; }

        public VentilViewModel()
        {
            string json = File.ReadAllText("DAL/VentilJSON.json");
            VentilList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<VentilClass>>(json);
        }
    }
}
