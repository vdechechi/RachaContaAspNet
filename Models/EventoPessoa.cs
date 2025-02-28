namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EventoPessoa
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("DiaEvento")]
    public int DiaEventoId { get; set; }
    public DiaEvento DiaEvento { get; set; }

    [ForeignKey("Pessoa")]
    public int PessoaId { get; set; }
    public Pessoa Pessoa { get; set; }
}
