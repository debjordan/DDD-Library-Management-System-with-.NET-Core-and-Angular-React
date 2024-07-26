using Microsoft.EntityFrameworkCore;

namespace ApiLibrary.Infrastructure.Contexts;
public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }
    public DbSet<Livro> Livros { get; set; } 
    public DbSet<Autor> Autores { get; set; } 
}