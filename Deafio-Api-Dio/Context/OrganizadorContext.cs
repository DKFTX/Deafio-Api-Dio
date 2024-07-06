using Deafio_Api_Dio.Models;
using Microsoft.EntityFrameworkCore;

namespace Deafio_Api_Dio.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext(DbContextOptions<OrganizadorContext> options) : base(options) 
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}
