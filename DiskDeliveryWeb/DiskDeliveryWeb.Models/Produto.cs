using System.ComponentModel.DataAnnotations;

namespace DiskDeliveryWeb.Models
{
    public class Produto
    {
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

        [Required]
        [Display(Name = "Descrição")]
        public bool Ativo { get; set; } 

        [Required(ErrorMessage = "A categoria do produto é obrigatória.")]
        [Display(Name = "Categoria")]
        public Categoria Categoria { get; set; } 
    }
}