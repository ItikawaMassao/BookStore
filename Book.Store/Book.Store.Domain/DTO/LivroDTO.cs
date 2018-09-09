namespace Book.Store.Domain.DTO
{
    public class LivroDTO : BaseDTO
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
    }
}