using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Book.Store.MVC.ViewModels.Livros
{
    public class LivroViewModel
    {
        [Key]
        public long Id { get; set; }

        public DateTime? DataInclusao { get; set; }
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Preencha o nome do livro")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Nome do livro")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o nome do autor do livro")]
        [MaxLength(200, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Autor do livro")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Preencha a editora do livro")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [DisplayName("Editora do livro")]
        public string Editora { get; set; }
    }
}