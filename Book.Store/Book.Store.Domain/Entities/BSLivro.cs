namespace Book.Store.Domain.Entities
{
    public class BsLivro : EntityBase
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
    }
}