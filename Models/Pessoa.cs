namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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

    [InverseProperty("Devedor")]
    public ICollection<Divisao> DevedorDivisoes { get; set; } = new List<Divisao>();

    [InverseProperty("Credor")]
    public ICollection<Divisao> CredorDivisoes { get; set; } = new List<Divisao>();
}
