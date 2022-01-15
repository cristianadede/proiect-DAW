using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.One_to_Many
{
    public class OtoMModel : BaseEntity
    {
        string Nume { get; set; }
        public ICollection<OtoMModel1> OtoMModels1 { get; set; }

    }
}
