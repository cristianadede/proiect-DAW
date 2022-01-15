using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Base
{
    public class BaseEntity : IBaseEntity
    {   
        [Key] //primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //pt autoincrementare (genereaza o val atunci cand se insereaza o linie)
        public Guid Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ? DataCreare { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)] //(genereaza o val atunci cand se insereaza/modifica o linie)
        public DateTime ? DataModificare { get; set; }
    }
}
