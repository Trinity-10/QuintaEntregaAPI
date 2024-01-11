using System.ComponentModel.DataAnnotations.Schema;

namespace Agencia.Model
{

    [Table("clientes")]

    public class Cliente

    {

        [Column("id")]
        public int Id { get; set; }

        [Column("nome_cliente")]
        public string NomeCliente { get; set; } = string.Empty;

        [Column("cpf_cliente")]
        public string CpfCliente { get; set; } = string.Empty;

        [Column("endereco_cliente")]
        public string EnderecoCliente { get; set; } = string.Empty;

        [Column("telefone_cliente")]
        public string TelefoneCliente { get; set; } = string.Empty;

        [Column("email_cliente")]
        public string EmailCliente { get; set; } = string.Empty;
    }
}