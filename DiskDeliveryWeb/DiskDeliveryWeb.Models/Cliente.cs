using System;

namespace DiskDeliveryWeb.Models
{
    public class Cliente
    {
        public int Id_Cliente { get; set; } 

        public string Nome { get; set; }    

        public string CPF { get; set; } 
        
        public string Email { get; set; }

        public Endereco Endereco { get; set; }

        public DateTime Data_Cadastro { get; set; }
    }
}