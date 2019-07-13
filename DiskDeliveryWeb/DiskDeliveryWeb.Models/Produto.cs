using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Código")]
        public int Id_Produto { get; set; }

        [Required(ErrorMessage = "O Nome do Produto é obrigatório.")]
        [Display(Name = "Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do Produto é obrigatório.")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatório.")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        public int Id_Categoria { get; set; }

        [ForeignKey("Id_Categoria")]
        [Required(ErrorMessage = "A categoria do produto é obrigatória.")]
        [Display(Name = "Categoria")]
        public Categoria Categoria { get; set; } 

        [Required]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; } 
    }
}