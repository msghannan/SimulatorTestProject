using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.Models
{
    public class PumpClass
    {
        public int Id { get; set; }
        public string PumpName { get; set; }
        public int Status { get; set; }
        public List<PipeClass> PumpPipeList { get; set; }
    }
}
