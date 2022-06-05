using Digesto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digesto.Infra
{
    public class DigestoContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DigestoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentCategory> DocumentsCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if(builder.IsConfigured)
            {
                return;
            }

            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
