using proiectDAW.Models.DTO;
using proiectDAW.Models.One_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Servicii
{
    public interface IGenService
    {
        GenDTO getById(Guid id);
        GenDTO getByIdCustom(Guid id);
        GenDTO getByTitleCustom(string title);
        GenDTO CreateGen(Gen entity);
        Gen FindById(Guid id);
        GenDTO updateGen(Guid id, Gen gen);
        void Save();
        GenDTO deleteGen(Gen gen);

    }
}
