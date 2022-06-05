using Digesto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Digesto.Infra
{
    public class DigestoContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DigestoContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public virtual DbSet<Broker> Brokers { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmailDocument> Documents { get; set; }
        public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public virtual DbSet<InsuranceQuoteRequest> InsuranceQuoteRequests { get; set; }
        public virtual DbSet<InsuranceType> InsuranceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broker>()
                .HasMany(x => x.InsuranceQuoteRequests)
                .WithOne(x => x.Broker)
                .HasForeignKey(x => x.BrokerId);

            modelBuilder.Entity<Customer>()
                .HasMany(x => x.InsuranceQuoteRequests)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId);

            modelBuilder.Entity<EmailDocument>()
                .HasOne(x => x.InsuranceType)
                .WithMany(x => x.EmailDocuments)
                .HasForeignKey(x => x.InsuranceTypeId);

            modelBuilder.Entity<EmailDocument>()
                .HasOne(x => x.Email)
                .WithMany(x => x.EmailDocuments)
                .HasForeignKey(x => x.EmailId);

            modelBuilder.Entity<Email>()
                .HasOne(x => x.InsuranceQuoteRequest)
                .WithMany(x => x.Emails)
                .HasForeignKey(x => x.InsuranceQuoteRequestId);

            modelBuilder.Entity<IndependentDocument>()
                .HasOne(x => x.InsuranceType)
                .WithMany(x => x.IndependentDocuments)
                .HasForeignKey(x => x.InsuranceTypeId);

            modelBuilder.Entity<IndependentDocument>()
                .HasOne(x => x.InsuranceQuoteRequest)
                .WithMany(x => x.IndependentDocuments)
                .HasForeignKey(x => x.InsuranceQuoteRequestId);

            modelBuilder.Entity<InsuranceType>()
                .HasMany(x => x.AvailableInsuranceCompanies)
                .WithMany(x => x.AvailableInsuranceTypes);
        }
    }
}
