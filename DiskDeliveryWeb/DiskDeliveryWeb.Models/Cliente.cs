using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DiskDeliveryWeb.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Display(Name = "Código")]
        public int Id_Cliente { get; set; } 

        [Required(ErrorMessage = "O Nome é obrigatório.")]
        [MaxLength(100, ErrorMessage="O Nome pode ter no maximo 100 caracteres"),MinLength(5, ErrorMessage="O Nome deve ter no minimo 5 caracteres")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }    

        public string CPF { get; set; } 
        
        public string Email { get; set; }

        
        public Endereco Endereco { get; set; }

        public DateTime Data_Cadastro { get; set; }
    }
}