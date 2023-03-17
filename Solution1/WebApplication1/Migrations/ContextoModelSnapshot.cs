﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Qr", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("Varchar(150)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("Varchar(50)")
                        .HasColumnName("Modelo");

                    b.Property<int>("propietario")
                        .HasColumnType("int")
                        .HasColumnName("Propietario");

                    b.HasKey("id");

                    b.ToTable("Qr");
                });

            modelBuilder.Entity("Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("Varchar(90)")
                        .HasColumnName("Nombre");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Zapato", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("String")
                        .HasColumnName("Modelo");

                    b.HasKey("id");

                    b.ToTable("Zapato");
                });
#pragma warning restore 612, 618
        }
    }
}