using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesFilmes.Model
{
    public class Filme
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 3)]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Gênero")]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Avaliação")]
        [Range(0, 5)]
        public int Avaliacao { get; set; } = 0;
    }
}
