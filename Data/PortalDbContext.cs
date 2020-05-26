using Microsoft.EntityFrameworkCore;
using Portal.Models;

namespace Portal.Data
{
    //PASO 3
    public class PortalDbContext : DbContext
    {

        //esta linea le dice a la base de datos que existira una tabla Noticias
        //using Portal.Models;
        public DbSet<Noticia> Noticias { get; set; }

        public DbSet<Noticia> Categorias { get; set; }


        //using Microsoft.EntityFrameworkCore;
        public PortalDbContext(DbContextOptions<PortalDbContext> o) : base(o){

        }
    }
}