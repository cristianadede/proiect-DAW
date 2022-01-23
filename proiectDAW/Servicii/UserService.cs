using Org.BouncyCastle.Crypto.Generators;
using proiectDAW.Data;
using proiectDAW.Models.DTO;
using proiectDAW.Models.Many_to_Many;
using proiectDAW.Utilities.JWT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Servicii
{
    public class UserService : IUserService
    {
        public Context Context;
        private IJwt IJWTUtils;
        public object BCryptNet { get; private set; }
        public UserResponseDTO Autentificare(UserRequestDTO model)
        {
            var user = Context.Utilizators.FirstOrDefault(u => u.Email == model.Email);

            //daca parola se potriveste cu has-ul din db
            // if (user == null || !BCryptNet.Verify(model.Parola, user.Parola))
            if (user == null) 
             {
                return null;
            }

            //JWT generation - json web token
            var jwtToken = IJWTUtils.GenerateJWTToken(user);
            return new UserResponseDTO(user, jwtToken);
        }

        public IEnumerable<Utilizator> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Utilizator GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public object GetById(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
