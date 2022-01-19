using proiectDAW.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Servicii
{
    public interface IServicii
    {
        //mapam un film dupa titlu
        ModelResultDTO GetDataMappedByTitle(string title);
    }
}
