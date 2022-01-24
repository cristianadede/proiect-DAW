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
        //save
        public void Save()
        {
            _genRepository.Save();
        }
        //get by id, by nume gen

        public Gen FindById(Guid id)
        {
            return _genRepository.FindById(id);
        }
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
            
            };

            return genDTO;
        }

        public GenDTO getByTitleCustom(string title)
        {
            Gen gen = _genRepository.GetByTitle(title);
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen,
         
            };

            return genDTO;
        }

        //creare - din generic repo
        public GenDTO CreateGen(Gen gen)
        {
            _genRepository.Create(gen);
            _genRepository.Save();
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen,
            };
            return genDTO;
        }

        //update - custom
 
        public GenDTO updateGen(Guid id, Gen gen)
        {
            _genRepository.updateGen(gen);
            _genRepository.Save();
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen,
            };
            return genDTO;
        }

        //delete
        public GenDTO deleteGen(Gen gen)
        {
            _genRepository.Delete(gen);
            GenDTO genDTO = new GenDTO()
            {
                NumeGen = gen.NumeGen,
            };
            return genDTO;
        }


    }
}
