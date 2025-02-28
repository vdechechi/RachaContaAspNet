namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Pagamento
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Compra")]
    public int CompraId { get; set; }
    public Compra Compra { get; set; }

    [ForeignKey("Pessoa")]
    public int PaganteId { get; set; }
    public Pessoa Pagante { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal Valor { get; set; }
}
