using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaWeb.Models
{
    public class Livro
    {
        [Key]
        [DisplayName("Código")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Título")]
        [StringLength(60)]
       public string Titulo { get; set; }

        [DisplayName("Autor(es)")]
        public string? Autor { get; set; }

      
    }
}
