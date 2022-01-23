using proiectDAW.Data;
using proiectDAW.Models.One_to_Many;
using proiectDAW.Repository.DatabaseRepository;
using proiectDAW.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Repository.GenRepository
{
    public class GenRepository : GenericRepository<Gen>, IGenRepository
    {
        public GenRepository(Context context) : base(context)
        {

        }

        public Gen GetByTitle(string title)
        {
            return _table.FirstOrDefault(gen => gen.NumeGen.ToLower().Equals(title.ToLower()));
        }

        public Gen GetById(Guid id)
        {
            return _table.FirstOrDefault(x => x.Id.ToString().Equals(id.ToString()));
        }
    }
}
