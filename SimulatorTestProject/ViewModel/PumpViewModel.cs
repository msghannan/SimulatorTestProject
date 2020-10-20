using SimulatorTestProject.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.ViewModel
{
    public class PumpViewModel
    {
        public List<PumpClass> PumpList { get; set; }

        public PumpViewModel()
        {
            string json = File.ReadAllText("DAL/PumpJSON.json");
            PumpList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PumpClass>>(json);
        }
    }
}
