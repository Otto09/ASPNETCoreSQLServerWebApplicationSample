﻿// <auto-generated />
using ASPNETCoreSQLServerWebApplicationSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNETCoreSQLServerWebApplicationSample.Migrations
{
    [DbContext(typeof(AnimalOwnersContext))]
    partial class AnimalOwnersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNETCoreSQLServerWebApplicationSample.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique()
                        .HasName("IX_Animal");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("ASPNETCoreSQLServerWebApplicationSample.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnimalId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Number");

                    b.Property<decimal>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("ASPNETCoreSQLServerWebApplicationSample.Models.Owner", b =>
                {
                    b.HasOne("ASPNETCoreSQLServerWebApplicationSample.Models.Animal", "Animal")
                        .WithMany("Owner")
                        .HasForeignKey("AnimalId");
                });
#pragma warning restore 612, 618
        }
    }
}
