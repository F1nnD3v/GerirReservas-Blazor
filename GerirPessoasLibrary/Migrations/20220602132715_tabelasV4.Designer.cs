﻿// <auto-generated />
using GerirInfosLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerirInfosLibrary.Migrations
{
    [DbContext(typeof(PessoaDbContext))]
    [Migration("20220602132715_tabelasV4")]
    partial class tabelasV4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerirInfosLibrary.Casa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("codigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("distrito")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_Dono")
                        .HasColumnType("int");

                    b.Property<string>("localidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("morada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero")
                        .HasColumnType("int");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("pessoaid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Casa");
                });

            modelBuilder.Entity("GerirInfosLibrary.Pessoa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("GerirInfosLibrary.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DataCheckIn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataCheckOut")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_status")
                        .HasColumnType("int");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_casa")
                        .HasColumnType("int");

                    b.Property<int>("id_cliente")
                        .HasColumnType("int");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("GerirInfosLibrary.Status", b =>
                {
                    b.Property<int>("Id_status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_status");

                    b.ToTable("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
