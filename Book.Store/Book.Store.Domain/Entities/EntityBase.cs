using Book.Store.Domain.Interfaces.Entities;
using System;

namespace Book.Store.Domain.Entities
{
    public class EntityBase : IEntityBase
    {
        public long Id { get; set; }
        public DateTime? DataInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}