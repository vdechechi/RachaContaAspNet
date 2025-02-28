namespace RachaConta.Models;

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

public class Evento
{
    [Key]  // Define a chave primária
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Nome { get; set; }

    public ICollection<DiaEvento> Dias { get; set; } = new List<DiaEvento>();
}
