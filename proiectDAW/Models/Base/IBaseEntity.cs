using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proiectDAW.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime ? DataCreare { get; set; }
        DateTime ? DataModificare { get; set; }
    }
}
