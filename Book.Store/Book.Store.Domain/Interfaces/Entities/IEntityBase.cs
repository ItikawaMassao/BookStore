using System;

namespace Book.Store.Domain.Interfaces.Entities
{
    public interface IEntityBase
    {
        long Id { get; set; }
        DateTime? DataInclusao { get; set; }
        bool Ativo { get; set; }
    }
}