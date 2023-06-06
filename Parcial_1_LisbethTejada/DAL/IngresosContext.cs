using Parcial_1_LisbethTejada.Models;
using Microsoft.EntityFrameworkCore;

namespace Parcial_1_LisbethTejada.DAL
{
    public class IngresosContext : DbContext
    {
        public IngresosContext(DbContextOptions<IngresosContext> options) : base(options)
        {

        }
        public DbSet<Ingresos> ingresos { get; set; }
    }
}
