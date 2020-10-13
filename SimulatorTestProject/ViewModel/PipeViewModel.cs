using SimulatorTestProject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.ViewModel
{
    public class PipeViewModel
    {
        public List<PipeClass> PipeList { get; set; }

        public PipeViewModel()
        {
            string json = File.ReadAllText("DAL/json.json");
            PipeList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<PipeClass>>(json);
        }

    }
}
