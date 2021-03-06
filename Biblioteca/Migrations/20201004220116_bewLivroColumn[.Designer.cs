﻿// <auto-generated />
using System;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Biblioteca.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20201004220116_bewLivroColumn[")]
    partial class bewLivroColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Biblioteca.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("multa")
                        .HasColumnType("bit");

                    b.Property<int>("telefone")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Biblioteca.Models.Emprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("funcionarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.HasIndex("funcionarioId");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("Biblioteca.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("Biblioteca.Models.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("ano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("autor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("editora")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("emprestado")
                        .HasColumnType("bit");

                    b.Property<string>("genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isbn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("Biblioteca.Models.LivroEmprestimo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmprestimoId")
                        .HasColumnType("int");

                    b.Property<int?>("livroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmprestimoId");

                    b.HasIndex("livroId");

                    b.ToTable("LivroEmprestimo");
                });

            modelBuilder.Entity("Biblioteca.Models.Emprestimo", b =>
                {
                    b.HasOne("Biblioteca.Models.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId");

                    b.HasOne("Biblioteca.Models.Funcionario", "funcionario")
                        .WithMany()
                        .HasForeignKey("funcionarioId");
                });

            modelBuilder.Entity("Biblioteca.Models.LivroEmprestimo", b =>
                {
                    b.HasOne("Biblioteca.Models.Emprestimo", null)
                        .WithMany("Itens")
                        .HasForeignKey("EmprestimoId");

                    b.HasOne("Biblioteca.Models.Livro", "livro")
                        .WithMany()
                        .HasForeignKey("livroId");
                });
#pragma warning restore 612, 618
        }
    }
}
