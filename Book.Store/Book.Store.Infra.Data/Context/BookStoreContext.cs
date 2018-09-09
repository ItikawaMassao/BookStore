using System;
using System.Data.Entity;
using Book.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Book.Store.Infra.Data.Context
{
    public sealed class BookStoreContext : DbContext
    {
        public IDbSet<BsLivro> Livros { get; private set; }

        public BookStoreContext()
            : base("BookStoreDBConnection")
        {
            Livros = Set<BsLivro>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name.ToUpperInvariant().Equals("ID")).Configure(p => p.IsKey());
            modelBuilder.Properties<string>().Configure(e => e.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(e => e.HasMaxLength(200));

            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataInclusao") != null))
            {
                if (EntityState.Added.Equals(entry.State))
                {
                    entry.Property("DataInclusao").CurrentValue = DateTime.Now;
                    entry.Property("Ativo").CurrentValue = true;
                }

                if (EntityState.Modified.Equals(entry.State))
                    entry.Property("DataInclusao").IsModified = false;
            }

            return base.SaveChanges();
        }
    }
}