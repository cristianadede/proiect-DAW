using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.One_to_One
{
    public class Model5 : BaseEntity
    {
        public string Name { get; set; }
        public Model6 Model6 { get; set; }

    }
}
