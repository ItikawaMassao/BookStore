using System;

namespace Book.Store.Domain.DTO
{
    public class BaseDTO
    {
        public long Id { get; set; }
        public DateTime? DataInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}