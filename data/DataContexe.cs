using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
namespace testEF
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Etudiant> Etudiants { get; set; }
    }

}
