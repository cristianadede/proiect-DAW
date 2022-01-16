using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class ActorFilm
    {
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
        public Guid ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
