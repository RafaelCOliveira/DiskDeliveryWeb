using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("Bairro")]
    public class Bairro
    {
        [Key]
        [Display(Name = "Código")]
        public int Id_Bairro { get; set; }

        [Required(ErrorMessage = "O Valor da descrição é obrigatório.")]
        [MaxLength(30, ErrorMessage="A Descrição do Bairro pode ter no maximo 30 caracteres"),MinLength(5, ErrorMessage="A Descrição do Bairro deve ter no minimo 5 caracteres")]
        [Display(Name = "Descrição")]
        public string Nome_Bairro { get; set; }
    }
}