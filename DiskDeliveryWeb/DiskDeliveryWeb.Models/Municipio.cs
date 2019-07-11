using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("Municipio")]
    public class Municipio
    {
        /* 
        CREATE TABLE MUNICIPIO (
        ID_MUNICIPIO    INTEGER NOT NULL,
        NOME_MUNICIPIO  VARCHAR(50),
        COD_UF          CHAR(2)
        ) ;
        */

        [Key]
        [MaxLength(2),MinLength(2)]
        public int Id_Municipio { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Municipio")]
        public string Descricao { get; set; }

        public UF UF  { get; set; }


    }
}