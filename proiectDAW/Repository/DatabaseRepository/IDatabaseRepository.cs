using proiectDAW.Models.Many_to_Many;
using proiectDAW.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Repository.DatabaseRepository
{
   public interface IDatabaseRepository : IGenericRepository<Film>
    {
        Film GetByTitle(string title);
        Film GetByTitleIncludingComentariu(string title);
        List<Film> GetAllWithInclude();
        List<Film> GetAllWithJoin();
    }
}
