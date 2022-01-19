using proiectDAW.Models.DTO;
using proiectDAW.Models.Many_to_Many;
using proiectDAW.Repository.DatabaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Servicii
{
    public class Servicii2 : IServicii
    {
        public IDatabaseRepository _databaseRepository;

        public Servicii2(IDatabaseRepository databaseRepository)
        {
            _databaseRepository = databaseRepository;
        }
        //prin dependencies injection - am configurat in Startup.cs linia 38
        public ModelResultDTO GetDataMappedByTitle(string title)
        {
            Film film = _databaseRepository.GetByTitle(title);

            ModelResultDTO result = new ModelResultDTO()
            {
                Titlu = film.Titlu,
                Limba = film.Limba
            };
            return result;
        }

    }
}
