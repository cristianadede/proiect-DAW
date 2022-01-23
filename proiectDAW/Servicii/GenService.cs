using proiectDAW.Models.DTO;
using proiectDAW.Models.One_to_Many;
using proiectDAW.Repository.GenRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Servicii
{
    public class GenService : IGenService
    {
        public IGenRepository _genRepository;
   
        //constructor
        public GenService(IGenRepository genRepository)
        {
            _genRepository = genRepository;
        }

        //get by id, by nume gen
        public GenDTO getById (Guid id)
        {
            Gen gen = _genRepository.FindById(id);
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen
            };

            return genDTO;
        }

        public GenDTO getByIdCustom(Guid id)
        {
            Gen gen = _genRepository.GetById(id);
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen,
                Id = gen.Id
            };

            return genDTO;
        }

        public GenDTO getByTitleCustom(string title)
        {
            Gen gen = _genRepository.GetByTitle(title);
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen,
                Id = gen.Id
            };

            return genDTO;
        }
    }
}
