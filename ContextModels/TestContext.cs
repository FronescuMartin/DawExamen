using examen.Entities;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace examen.ContextModels
{
    public class TestContext : DbContext
    {
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Carte> Carte { get; set; }
        public DbSet<Publicatie> Publicatie { get; set; }
        public DbSet<Editura> Editura { get; set; }

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {

        }
    }
}
