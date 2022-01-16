using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.One_to_Many
{
    public class Model2 : BaseEntity {
        public string Name { get; set; }
        public Model1 Model1 { get; set; }
        public Guid Model1Id { get; set; }

    }
}
