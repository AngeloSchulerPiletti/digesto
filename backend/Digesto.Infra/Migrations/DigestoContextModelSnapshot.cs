// <auto-generated />
using System;
using Digesto.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Digesto.Infra.Migrations
{
    [DbContext(typeof(DigestoContext))]
    partial class DigestoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Digesto.Domain.Entities.Broker", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Brokers");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.Customer", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.Email", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<uint>("InsuranceQuoteRequestId")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceQuoteRequestId");

                    b.ToTable("Emails");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.EmailDocument", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<uint>("EmailId")
                        .HasColumnType("int unsigned");

                    b.Property<uint?>("InsuranceTypeId")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EmailId");

                    b.HasIndex("InsuranceTypeId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.IndependentDocument", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<uint>("InsuranceQuoteRequestId")
                        .HasColumnType("int unsigned");

                    b.Property<uint?>("InsuranceTypeId")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("InsuranceQuoteRequestId");

                    b.HasIndex("InsuranceTypeId");

                    b.ToTable("IndependentDocument");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.InsuranceCompany", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<string>("ContactEmail")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("InsuranceCompanies");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.InsuranceQuoteRequest", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<uint>("BrokerId")
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<uint>("CustomerId")
                        .HasColumnType("int unsigned");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("BrokerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("InsuranceQuoteRequests");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.InsuranceType", b =>
                {
                    b.Property<uint>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int unsigned");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("InsuranceTypes");
                });

            modelBuilder.Entity("InsuranceCompanyInsuranceType", b =>
                {
                    b.Property<uint>("AvailableInsuranceCompaniesId")
                        .HasColumnType("int unsigned");

                    b.Property<uint>("AvailableInsuranceTypesId")
                        .HasColumnType("int unsigned");

                    b.HasKey("AvailableInsuranceCompaniesId", "AvailableInsuranceTypesId");

                    b.HasIndex("AvailableInsuranceTypesId");

                    b.ToTable("InsuranceCompanyInsuranceType");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.Email", b =>
                {
                    b.HasOne("Digesto.Domain.Entities.InsuranceQuoteRequest", "InsuranceQuoteRequest")
                        .WithMany("Emails")
                        .HasForeignKey("InsuranceQuoteRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InsuranceQuoteRequest");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.EmailDocument", b =>
                {
                    b.HasOne("Digesto.Domain.Entities.Email", "Email")
                        .WithMany("EmailDocuments")
                        .HasForeignKey("EmailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digesto.Domain.Entities.InsuranceType", "InsuranceType")
                        .WithMany("EmailDocuments")
                        .HasForeignKey("InsuranceTypeId");

                    b.Navigation("Email");

                    b.Navigation("InsuranceType");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.IndependentDocument", b =>
                {
                    b.HasOne("Digesto.Domain.Entities.InsuranceQuoteRequest", "InsuranceQuoteRequest")
                        .WithMany("IndependentDocuments")
                        .HasForeignKey("InsuranceQuoteRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digesto.Domain.Entities.InsuranceType", "InsuranceType")
                        .WithMany("IndependentDocuments")
                        .HasForeignKey("InsuranceTypeId");

                    b.Navigation("InsuranceQuoteRequest");

                    b.Navigation("InsuranceType");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.InsuranceQuoteRequest", b =>
                {
                    b.HasOne("Digesto.Domain.Entities.Broker", "Broker")
                        .WithMany("InsuranceQuoteRequests")
                        .HasForeignKey("BrokerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digesto.Domain.Entities.Customer", "Customer")
                        .WithMany("InsuranceQuoteRequests")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Broker");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("InsuranceCompanyInsuranceType", b =>
                {
                    b.HasOne("Digesto.Domain.Entities.InsuranceCompany", null)
                        .WithMany()
                        .HasForeignKey("AvailableInsuranceCompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Digesto.Domain.Entities.InsuranceType", null)
                        .WithMany()
                        .HasForeignKey("AvailableInsuranceTypesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Digesto.Domain.Entities.Broker", b =>
                {
                    b.Navigation("InsuranceQuoteRequests");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.Customer", b =>
                {
                    b.Navigation("InsuranceQuoteRequests");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.Email", b =>
                {
                    b.Navigation("EmailDocuments");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.InsuranceQuoteRequest", b =>
                {
                    b.Navigation("Emails");

                    b.Navigation("IndependentDocuments");
                });

            modelBuilder.Entity("Digesto.Domain.Entities.InsuranceType", b =>
                {
                    b.Navigation("EmailDocuments");

                    b.Navigation("IndependentDocuments");
                });
#pragma warning restore 612, 618
        }
    }
}
