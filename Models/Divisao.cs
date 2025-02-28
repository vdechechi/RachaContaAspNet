namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Divisao
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Compra")]
    public int CompraId { get; set; }
    public Compra Compra { get; set; }

    [ForeignKey("Devedor")]
    public int DevedorId { get; set; }
    public Pessoa Devedor { get; set; }

    [ForeignKey("Credor")]
    public int CredorId { get; set; }
    public Pessoa Credor { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Valor { get; set; }
}
