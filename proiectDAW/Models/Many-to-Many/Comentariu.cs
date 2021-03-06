using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class Comentariu : BaseEntity
    {
        public Guid UtilizatorId { get; set; }
        public Utilizator Utilizator { get; set; }
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        public string Mesaj { get; set; }
    }
}
