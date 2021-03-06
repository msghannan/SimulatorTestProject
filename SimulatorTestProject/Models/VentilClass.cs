﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.Models
{
    public class VentilClass
    {
        public int Id { get; set; }
        public string VentilName { get; set; }
        public int Status { get; set; }
        public bool Activatable { get; set; }
        public List<PipeClass> VentilPipeList { get; set; }
    }
}
