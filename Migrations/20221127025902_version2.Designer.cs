﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pagamento_prova.Models;

#nullable disable

namespace pagamento_prova.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20221127025902_version2")]
    partial class version2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pagamento_prova.Models.Consumidor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Consumidor");
                });

            modelBuilder.Entity("pagamento_prova.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("IdPedido")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("IdPedido")
                        .IsUnique();

                    b.ToTable("Pagamento");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pagamento");
                });

            modelBuilder.Entity("pagamento_prova.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("ComDesconto")
                        .HasColumnType("boolean");

                    b.Property<int>("ConsumidorId")
                        .HasColumnType("integer");

                    b.Property<DateOnly>("Data")
                        .HasColumnType("date");

                    b.Property<double>("Desconto")
                        .HasColumnType("double precision");

                    b.Property<int?>("IdConsumidor")
                        .HasColumnType("integer");

                    b.Property<int?>("IdPagamento")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ConsumidorId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("pagamento_prova.Models.Produto", b =>
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

            modelBuilder.Entity("pagamento_prova.Models.Boleto", b =>
                {
                    b.HasBaseType("pagamento_prova.Models.Pagamento");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Confirmado")
                        .HasColumnType("boolean");

                    b.HasDiscriminator().HasValue("Boleto");
                });

            modelBuilder.Entity("pagamento_prova.Models.Cartaodecredito", b =>
                {
                    b.HasBaseType("pagamento_prova.Models.Pagamento");

                    b.Property<string>("Digito")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Parcelas")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("Cartaodecredito");
                });

            modelBuilder.Entity("pagamento_prova.Models.Pagamento", b =>
                {
                    b.HasOne("pagamento_prova.Models.Pedido", "Pedido")
                        .WithOne("Pagamento")
                        .HasForeignKey("pagamento_prova.Models.Pagamento", "IdPedido");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("pagamento_prova.Models.Pedido", b =>
                {
                    b.HasOne("pagamento_prova.Models.Consumidor", "Consumidor")
                        .WithMany("Pedido")
                        .HasForeignKey("ConsumidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consumidor");
                });

            modelBuilder.Entity("pagamento_prova.Models.Produto", b =>
                {
                    b.HasOne("pagamento_prova.Models.Pedido", null)
                        .WithMany("Produto")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("pagamento_prova.Models.Consumidor", b =>
                {
                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("pagamento_prova.Models.Pedido", b =>
                {
                    b.Navigation("Pagamento");

                    b.Navigation("Produto");
                });
#pragma warning restore 612, 618
        }
    }
}
