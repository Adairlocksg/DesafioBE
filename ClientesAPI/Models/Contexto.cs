using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {


        }
        public DbSet<Clientes> Clientes { get; set; }

     }
}
