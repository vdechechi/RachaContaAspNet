namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

public class DiaEvento
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Evento")]
    public int EventoId { get; set; }
    public Evento Evento { get; set; }

    [Required]
    public DateTime Data { get; set; }

    public ICollection<EventoPessoa> Participantes { get; set; } = new List<EventoPessoa>();
    public ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
