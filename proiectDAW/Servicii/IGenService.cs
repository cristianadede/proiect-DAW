using proiectDAW.Models.DTO;
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

    }
}
