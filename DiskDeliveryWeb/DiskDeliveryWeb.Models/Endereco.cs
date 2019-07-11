namespace DiskDeliveryWeb.Models
{
    public class Endereco
    {
        public int Id_Endereco { get; set; }
        public int Id_Cliente { get; set; }
        public int Id_Logradouro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public int Id_Bairro { get; set; }
        public string CEP { get; set; }
        public string Cod_UF { get; set; }
        public int Id_Municipio { get; set; }

    }
}