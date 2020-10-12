using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.Models
{
    public class AllProductClass
    {
        public List<PipeClass> PipeList { get; set; }
        public List<PumpClass> PumpList { get; set; }
        public List<VentilClass> VentilList { get; set; }
    }
}
