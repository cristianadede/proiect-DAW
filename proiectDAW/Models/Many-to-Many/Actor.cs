using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class Actor : BaseEntity
    {
       public string Nume { get; set; }
       public string Prenume { get; set; }
       public int Varsta { get; set; }

       public ICollection<ActorFilm> ActorFilms { get; set; }
    }
}
