namespace RachaConta.Data;

using Microsoft.EntityFrameworkCore;
using RachaConta.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Evento> Eventos { get; set; }
    public DbSet<DiaEvento> DiasEvento { get; set; }
    public DbSet<Pessoa> Pessoas { get; set; }
    public DbSet<EventoPessoa> EventoPessoas { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<CompraParticipante> CompraParticipantes { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<Divisao> Divisoes { get; set; }
    public DbSet<Saldo> Saldos { get; set; }
}
