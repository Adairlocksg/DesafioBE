using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClientesAPI.Models
{
    public class Clientes
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("cnpj")]
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Column("endereco")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }


        [Column("dt_cadastro")]
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        public string dt_cadastro { get; set; }

        [Column("telefone")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}
