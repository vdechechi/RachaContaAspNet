namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

public class Compra
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Nome { get; set; }

    [Required]
    [Column(TypeName = "decimal(10,2)")]
    public decimal ValorTotal { get; set; }

    [ForeignKey("DiaEvento")]
    public int DiaEventoId { get; set; }
    public DiaEvento DiaEvento { get; set; }

    public ICollection<CompraParticipante> Participantes { get; set; } = new List<CompraParticipante>();
    public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
