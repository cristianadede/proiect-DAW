using proiectDAW.Models.One_to_Many;
using proiectDAW.Repository.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Repository.GenRepository
{
   public interface IGenRepository : IGenericRepository<Gen>
    {
        Gen GetByTitle(string title);
        Gen GetById(Guid id);
        void updateGen(Gen gen);
    }
}
