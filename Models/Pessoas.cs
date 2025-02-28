namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Pessoa
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Nome { get; set; }

    public ICollection<EventoPessoa> Eventos { get; set; } = new List<EventoPessoa>();
    public ICollection<CompraParticipante> Compras { get; set; } = new List<CompraParticipante>();
    public ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
    public ICollection<Divisao> DevedorDivisoes { get; set; } = new List<Divisao>();
    public ICollection<Divisao> CredorDivisoes { get; set; } = new List<Divisao>();
}
