using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("UF")]
    public class UF
    {
        [Key]
        [Display(Name = "UF")]
        [MaxLength(2),MinLength(2)]
        public string Cod_UF { get; set; }

        [Required]
        [MaxLength(30),MinLength(2)]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}