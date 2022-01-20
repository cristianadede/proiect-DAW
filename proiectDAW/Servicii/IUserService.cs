using proiectDAW.Models.DTO;
using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Servicii
{
    public interface IUserService
    {
        //Autentificare
        UserResponseDTO Autentificare(UserRequestDTO model);

        //GetAll
        IEnumerable<Utilizator> GetAllUsers();

        //Get by id
        Utilizator GetById(Guid id);
        object GetById(string userId);
    }
}
