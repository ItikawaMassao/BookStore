using Book.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Book.Store.Infra.Data.EntityConfig
{
    public class LivroConfiguration : EntityTypeConfiguration<BsLivro>
    {
        public LivroConfiguration()
        {
            HasKey(e => e.Id);

            Property(e => e.Nome).IsRequired();

            Property(e => e.Autor).IsRequired();

            Property(e => e.Editora).HasMaxLength(100).IsRequired();
        }
    }
}