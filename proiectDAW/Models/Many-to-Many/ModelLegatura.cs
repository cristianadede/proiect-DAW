﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class ModelLegatura 
    {
        public Guid Model3Id { get; set; }
        public Model3 Model3 { get; set; }
        public Guid Model4Id { get; set; }
        public Model4 Model4 { get; set; }
    }
}
