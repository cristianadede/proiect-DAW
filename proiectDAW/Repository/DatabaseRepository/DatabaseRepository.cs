using Microsoft.EntityFrameworkCore;
using proiectDAW.Data;
using proiectDAW.Models.Many_to_Many;
using proiectDAW.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Repository.DatabaseRepository
{
    public class DatabaseRepository : GenericRepository<Film>, IDatabaseRepository
    {
        public DatabaseRepository(Context context) : base(context)
        {

        }

        public List<Film> GetAllWithInclude()
        {
            //include ca sa aduca si din tabele comentariu
            return _table.Include(c => c.Comentarius).ToList();
        }

        //extra info, de obicei folosim include
        //task si await daca vrem sa fie async
        public List<Film> GetAllWithJoin()
        {
            var rezultat = _table.Join(
                _context.Comentarius, //Tabel sursa pt join
                film => film.Id, //PK
                comentariu => comentariu.FilmId, //FK
                (film, comentariu) => new { film, comentariu }).Select(obj => obj.film); //selectia

            return rezultat.ToList();
        }

        public Film GetByTitle(string title)
        {
            return _table.FirstOrDefault(film => film.Titlu.ToLower().Equals(title.ToLower()));
        }

        public Film GetByTitleIncludingComentariu(string title)
        {
            return _table.Include(c => c.Comentarius).FirstOrDefault(film => film.Titlu.ToLower().Equals(title));
        }
    }
}
