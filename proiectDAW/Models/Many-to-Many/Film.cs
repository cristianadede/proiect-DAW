using proiectDAW.Models.Base;
using proiectDAW.Models.One_to_Many;
using proiectDAW.Models.One_to_One;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class Film : BaseEntity
    {
        public string Titlu { get; set; }
        public string Limba { get; set; }
        public string Data { get; set; }
        public Gen Gen { get; set; }
        public Guid GenId { get; set; }
        public Detaliu Detaliu { get; set; }
        public Guid DetaliuId { get; set; }
        public ICollection<Comentariu> Comentarius { get; set; }
        public ICollection<ActorFilm> ActorFilms { get; set; }
    }
}
