using proiectDAW.Models.Many_to_Many;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.DTO
{
    //Data transfer object
    //Folosim DTO atunci cand nu avem nevoie de toate datele dintr-o tabela
    public class UserResponseDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public UserResponseDTO(Utilizator user, string token)
        {
            Id = user.Id;
            Nume = user.Nume;
            Prenume = user.Prenume;
            Email = user.Email;
            Token = token;
        }
    }
}
