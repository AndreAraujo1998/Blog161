﻿// <auto-generated />
using System;
using AtividadeBlog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AtividadeBlog.Migrations
{
    [DbContext(typeof(AtividadeBlogContext))]
    [Migration("20190819184040_atualizacao")]
    partial class atualizacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AtividadeBlog.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("AtividadeBlog.Comentario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Autor");

                    b.Property<DateTime>("DataComentario");

                    b.Property<string>("Descricao");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("AtividadeBlog.Mensagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<DateTime>("DataMensagem");

                    b.Property<string>("Descricao");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Mensagem");
                });

            modelBuilder.Entity("AtividadeBlog.Mensagem", b =>
                {
                    b.HasOne("AtividadeBlog.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}