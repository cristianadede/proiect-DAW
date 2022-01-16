using proiectDAW.Models.Base;
using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.One_to_Many
{
    public class Gen : BaseEntity
    {
        public string NumeGen { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
