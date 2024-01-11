using Agencia.Model;
using Microsoft.EntityFrameworkCore;

namespace Agencia.Data
{

  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Cliente> Clientes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Cliente>().HasData(
        new Cliente { Id = 1, NomeCliente = "Ana", CpfCliente = "111.895.787-11", EnderecoCliente = "bla bla bla", TelefoneCliente = "1111", EmailCliente = "01@hotmail" },
        new Cliente { Id = 2, NomeCliente = "Joana", CpfCliente = "222.895.787-11", EnderecoCliente = "logo ali", TelefoneCliente = "2222", EmailCliente = "02@hotmail" },
        new Cliente { Id = 3, NomeCliente = "Mara", CpfCliente = "333.895.787-11", EnderecoCliente = "bla bla bla", TelefoneCliente = "3333", EmailCliente = "03@hotmail" },
        new Cliente { Id = 4, NomeCliente = "Anderson", CpfCliente = "444.895.787-11", EnderecoCliente = "logo ali", TelefoneCliente = "4444", EmailCliente = "04@hotmail" }
      );
    } 
  } 
}