namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Saldo
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Pessoa")]
    public int PessoaId { get; set; }
    public Pessoa Pessoa { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Valor { get; set; }
}
