﻿// <auto-generated />
using System;
using Livraria.Application.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Livraria.Data.Migrations
{
    [DbContext(typeof(LivrariaContext))]
    partial class LivrariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Livraria.Application.Entities.Genero", b =>
                {
                    b.Property<Guid>("IdGenero")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.HasKey("IdGenero");

                    b.ToTable("genero");
                });

            modelBuilder.Entity("Livraria.Application.Entities.Livro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao");

                    b.Property<Guid?>("GeneroIdGenero");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("GeneroIdGenero");

                    b.ToTable("livro");
                });

            modelBuilder.Entity("Livraria.Application.Entities.Livro", b =>
                {
                    b.HasOne("Livraria.Application.Entities.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroIdGenero");
                });
#pragma warning restore 612, 618
        }
    }
}
