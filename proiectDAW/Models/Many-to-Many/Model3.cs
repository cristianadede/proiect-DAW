﻿using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class Model3 : BaseEntity
    {
        string Name { get; set; }
        // public ICollection<Model4> Models4 { get; set; }

        public ICollection<ModelLegatura> ModelLegaturas { get; set; }
    }
}
