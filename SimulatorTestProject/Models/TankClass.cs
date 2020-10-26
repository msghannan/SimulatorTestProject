﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimulatorTestProject.Models
{
    public class TankClass
    {
        public int Id { get; set; }
        public string TankName { get; set; }
        public int Status { get; set; }
        public bool Activatable { get; set; }
        public string ImageSRCActive { get; set; }
    }
}
