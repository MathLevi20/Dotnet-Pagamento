﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pagamento.Models;

#nullable disable

namespace pagamento.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pagamento.Models.Consumidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Consumidor");
                });

            modelBuilder.Entity("pagamento.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Pagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pagamento");
                });

            modelBuilder.Entity("pagamento.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ConsumidorId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("PagamentoId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConsumidorId");

                    b.HasIndex("PagamentoId")
                        .IsUnique();

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("pagamento.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("integer");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("pagamento.Models.Boleto", b =>
                {
                    b.HasBaseType("pagamento.Models.Pagamento");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Confirmado")
                        .HasColumnType("boolean");

                    b.HasDiscriminator().HasValue("Boleto");
                });

            modelBuilder.Entity("pagamento.Models.Cartaodecredito", b =>
                {
                    b.HasBaseType("pagamento.Models.Pagamento");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Parcelas")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Cartaodecredito");
                });

            modelBuilder.Entity("pagamento.Models.Pedido", b =>
                {
                    b.HasOne("pagamento.Models.Consumidor", "Consumidor")
                        .WithMany()
                        .HasForeignKey("ConsumidorId");

                    b.HasOne("pagamento.Models.Pagamento", "Pagamento")
                        .WithOne("Pedido")
                        .HasForeignKey("pagamento.Models.Pedido", "PagamentoId");

                    b.Navigation("Consumidor");

                    b.Navigation("Pagamento");
                });

            modelBuilder.Entity("pagamento.Models.Produto", b =>
                {
                    b.HasOne("pagamento.Models.Pedido", null)
                        .WithMany("items")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("pagamento.Models.Pagamento", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("pagamento.Models.Pedido", b =>
                {
                    b.Navigation("items");
                });
#pragma warning restore 612, 618
        }
    }
}
