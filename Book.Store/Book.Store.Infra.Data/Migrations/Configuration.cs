using Book.Store.Domain.Entities;
using Book.Store.Infra.Data.Context;
using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Book.Store.Infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Book.Store.Infra.Data.Context.BookStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BookStoreContext context)
        {
            var livros = new Collection<BsLivro>
            {
                new BsLivro
                {
                    Ativo = true,
                    DataInclusao = DateTime.Now,
                    Autor = "Robert C. Martin",
                    Nome = "Clean Code - A Handbook of Agile Software Craftsmanship",
                    Editora = "Prentice Hall PTR"
                },
                new BsLivro
                {
                    Ativo = true,
                    DataInclusao = DateTime.Now,
                    Autor = "Erich Gama",
                    Nome = "Padrões de Projetos",
                    Editora = "Bookman"
                },
                new BsLivro
                {
                    Ativo = true,
                    DataInclusao = DateTime.Now,
                    Autor = "Robert C. Martin",
                    Nome = "Princípios, Padrões e Práticas Ágeis em C#",
                    Editora = "Bookman"
                }
            };

            context.Set<BsLivro>().AddOrUpdate(e => e.Nome, livros.ToArray());

            base.Seed(context);
        }
    }
}