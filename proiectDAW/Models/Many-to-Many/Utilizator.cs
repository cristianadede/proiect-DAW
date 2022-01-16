using proiectDAW.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Many_to_Many
{
    public class Utilizator : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Parola { get; set; } 

        public ICollection<Comentariu> Comentarius { get; set; }
    }
}
