using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Key]
        [Display(Name = "Código")]
        public int Id_Categoria { get; set; }

        [Required(ErrorMessage = "O Valor da descrição é obrigatório.")]
        [MaxLength(30, ErrorMessage="A Descrição da Categoria pode ter no maximo 30 caracteres"),MinLength(5, ErrorMessage="A Descrição da Categoria deve ter no minimo 5 caracteres")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}