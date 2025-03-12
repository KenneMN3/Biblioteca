using Biblioteca.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
   : base(options)
    {
    }
    public DbSet<LibrosModels> Libros { get; set; }
    public DbSet<AutoresModels> Autores { get; set; }

}