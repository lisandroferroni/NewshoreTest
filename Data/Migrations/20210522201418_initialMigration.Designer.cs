// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(NewshoreDbContext))]
    [Migration("20210522201418_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Flight", b =>
                {
                    b.Property<string>("ArrivalStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransportFligthNumber")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("TransportFligthNumber");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("Model.Transport", b =>
                {
                    b.Property<string>("FligthNumber")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FligthNumber");

                    b.ToTable("Transports");
                });

            modelBuilder.Entity("Model.Flight", b =>
                {
                    b.HasOne("Model.Transport", "Transport")
                        .WithMany()
                        .HasForeignKey("TransportFligthNumber");

                    b.Navigation("Transport");
                });
#pragma warning restore 612, 618
        }
    }
}
