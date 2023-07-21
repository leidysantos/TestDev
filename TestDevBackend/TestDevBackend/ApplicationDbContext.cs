using Microsoft.EntityFrameworkCore;
using TestDevBackend.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Agregar DbSet para cada modelo que desees mapear a tablas en la base de datos
    public DbSet<libros> Libros { get; set; }
    public DbSet<autores> Autores { get; set; }
    public DbSet<editoriales> Editoriales { get; set; }
    public DbSet<autoresHasLibros> AutoresHasLibros{ get; set; }
}
