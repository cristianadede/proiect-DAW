using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.One_to_Many
{
    public class Model1 : BaseEntity {
        public string Name { get; set; }
        public ICollection<Model2> Models2 { get; set; }
    }
}
