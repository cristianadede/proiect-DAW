using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Utilities.JWT
{
   public interface IJwt
    {
        //generare token
        public string GenerateJWTToken(Utilizator user);

        //validare token
        public Guid ValidateJWTToken(string token);
    }
}
