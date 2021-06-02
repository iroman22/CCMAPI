﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Models;

namespace api.Data.Migrations
{
    [DbContext(typeof(GlobalContext))]
    partial class GlobalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api.Models.Traffic.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gerente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Hora_Visita")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("api.Models.Traffic.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Exclusive_Db")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Validacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("api.Models.Traffic.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_Gestion")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Extras");
                });

            modelBuilder.Entity("api.Models.Traffic.Gestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Gestion")
                        .HasColumnType("datetime2");

                    b.Property<int>("ValijaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ValijaId");

                    b.ToTable("Gestiones");
                });

            modelBuilder.Entity("api.Models.Traffic.Ruta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Estado_Ruta")
                        .HasColumnType("int");

                    b.Property<DateTime>("Hora_Visita")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tipo_Ruta")
                        .HasColumnType("int");

                    b.Property<int>("Turno")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ruta");
                });

            modelBuilder.Entity("api.Models.Traffic.RutaBranch", b =>
                {
                    b.Property<int>("RutaId")
                        .HasColumnType("int");

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.HasKey("RutaId", "BranchId");

                    b.HasIndex("BranchId");

                    b.ToTable("RutaBranch");
                });

            modelBuilder.Entity("api.Models.Traffic.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Certified")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<byte[]>("ContraHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ContraSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Created_By")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha_Contratacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono_Casa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_Actor")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Tipo_Sangre")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("api.Models.Traffic.Valija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destino")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado_Valija")
                        .HasColumnType("bit");

                    b.Property<string>("Origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Peso_Excedente")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("RutaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RutaId");

                    b.ToTable("Valijas");
                });

            modelBuilder.Entity("api.Models.Traffic.Branch", b =>
                {
                    b.HasOne("api.Models.Traffic.Cliente", "Clientes")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clientes");
                });

            modelBuilder.Entity("api.Models.Traffic.Gestion", b =>
                {
                    b.HasOne("api.Models.Traffic.Valija", "Valijas")
                        .WithMany()
                        .HasForeignKey("ValijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Valijas");
                });

            modelBuilder.Entity("api.Models.Traffic.Ruta", b =>
                {
                    b.HasOne("api.Models.Traffic.User", "Users")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("api.Models.Traffic.RutaBranch", b =>
                {
                    b.HasOne("api.Models.Traffic.Branch", "Branches")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.Traffic.Ruta", "Rutas")
                        .WithMany()
                        .HasForeignKey("RutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branches");

                    b.Navigation("Rutas");
                });

            modelBuilder.Entity("api.Models.Traffic.Valija", b =>
                {
                    b.HasOne("api.Models.Traffic.Ruta", "Rutas")
                        .WithMany()
                        .HasForeignKey("RutaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rutas");
                });
#pragma warning restore 612, 618
        }
    }
}
