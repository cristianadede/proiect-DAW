using proiectDAW.Models.Base;
using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.One_to_One
{
    public class Detaliu : BaseEntity
    {
        public string Descriere { get; set; }
        public int Durata { get; set; }
        public Film Film { get; set; }
        public Guid FilmId { get; set; }
    }
}
