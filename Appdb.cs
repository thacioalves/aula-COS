using Microsoft.EntityFrameworkCore;

namespace aula_COS;

public class Appdb : DbContext
{
    public Appdb(DbContextOptions<Appdb> options) : base(options)
    {
    }

    // Defina suas entidades (tabelas)
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql("Server=localhost;Database=meu_banco;User=usuario;Password=senha_usuario;", 
                new MySqlServerVersion(new Version(8, 0, 21)));
        }
    }
}

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
