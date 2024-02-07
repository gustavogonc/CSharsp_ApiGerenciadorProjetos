using ApiGerenciadorProjetos.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiGerenciadorProjetos.Database
{
    public class MySqlContext : DbContext
    {

        public MySqlContext()
        {
            
        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            
        }
        public DbSet<User> User { get; set; }
    }
}
