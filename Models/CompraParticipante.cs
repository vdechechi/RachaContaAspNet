namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class CompraParticipante
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Compra")]
    public int CompraId { get; set; }
    public Compra Compra { get; set; }

    [ForeignKey("Pessoa")]
    public int PessoaId { get; set; }
    public Pessoa Pessoa { get; set; }
}
