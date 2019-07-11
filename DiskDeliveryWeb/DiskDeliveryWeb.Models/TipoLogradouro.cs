using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("TipoLogradouro")]
    public class TipoLogradouro
    {
        [Key]
        public int Id_Logradouro { get; set; }

        [Required]
        [MaxLength(30),MinLength(5)]
        [Display(Name = "Tipo Logradouro")]
        public string Descricao { get; set; }
    }
}