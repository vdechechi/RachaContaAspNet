﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RachaConta.Data;

#nullable disable

namespace RachaConta.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250228211430_Populando")]
    partial class Populando
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RachaConta.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiaEventoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("DiaEventoId");

                    b.ToTable("Compras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiaEventoId = 1,
                            Nome = "Mercado 1",
                            ValorTotal = 850.00m
                        },
                        new
                        {
                            Id = 2,
                            DiaEventoId = 3,
                            Nome = "Adega",
                            ValorTotal = 400.00m
                        });
                });

            modelBuilder.Entity("RachaConta.Models.CompraParticipante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("PessoaId");

                    b.ToTable("CompraParticipantes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            PessoaId = 2
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 1,
                            PessoaId = 3
                        },
                        new
                        {
                            Id = 3,
                            CompraId = 2,
                            PessoaId = 1
                        },
                        new
                        {
                            Id = 4,
                            CompraId = 2,
                            PessoaId = 5
                        });
                });

            modelBuilder.Entity("RachaConta.Models.DiaEvento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.ToTable("DiasEvento");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Data = new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Data = new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventoId = 1
                        },
                        new
                        {
                            Id = 3,
                            Data = new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventoId = 1
                        },
                        new
                        {
                            Id = 4,
                            Data = new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventoId = 1
                        },
                        new
                        {
                            Id = 5,
                            Data = new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EventoId = 1
                        });
                });

            modelBuilder.Entity("RachaConta.Models.Divisao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("CredorId")
                        .HasColumnType("int");

                    b.Property<int>("DevedorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("CredorId");

                    b.HasIndex("DevedorId");

                    b.ToTable("Divisoes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            CredorId = 2,
                            DevedorId = 3,
                            Valor = 85.00m
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 1,
                            CredorId = 2,
                            DevedorId = 4,
                            Valor = 85.00m
                        },
                        new
                        {
                            Id = 3,
                            CompraId = 2,
                            CredorId = 3,
                            DevedorId = 1,
                            Valor = 50.00m
                        },
                        new
                        {
                            Id = 4,
                            CompraId = 2,
                            CredorId = 4,
                            DevedorId = 5,
                            Valor = 16.67m
                        });
                });

            modelBuilder.Entity("RachaConta.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Eventos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Praia Carnaval 2025"
                        });
                });

            modelBuilder.Entity("RachaConta.Models.EventoPessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DiaEventoId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DiaEventoId");

                    b.HasIndex("PessoaId");

                    b.ToTable("EventoPessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DiaEventoId = 1,
                            PessoaId = 2
                        },
                        new
                        {
                            Id = 2,
                            DiaEventoId = 1,
                            PessoaId = 3
                        },
                        new
                        {
                            Id = 3,
                            DiaEventoId = 1,
                            PessoaId = 4
                        },
                        new
                        {
                            Id = 4,
                            DiaEventoId = 1,
                            PessoaId = 5
                        });
                });

            modelBuilder.Entity("RachaConta.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<int>("PaganteId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("PaganteId");

                    b.ToTable("Pagamentos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompraId = 1,
                            PaganteId = 2,
                            Valor = 850.00m
                        },
                        new
                        {
                            Id = 2,
                            CompraId = 2,
                            PaganteId = 3,
                            Valor = 300.00m
                        },
                        new
                        {
                            Id = 3,
                            CompraId = 2,
                            PaganteId = 4,
                            Valor = 100.00m
                        });
                });

            modelBuilder.Entity("RachaConta.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Vinicius"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Gabriel"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Murilo"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "Jonas"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "Miguel"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "Fernando"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "Gustavo"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "Joao"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "Jose"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "Sergio"
                        });
                });

            modelBuilder.Entity("RachaConta.Models.Saldo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Saldos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PessoaId = 2,
                            Valor = 850.00m
                        },
                        new
                        {
                            Id = 2,
                            PessoaId = 3,
                            Valor = 300.00m
                        },
                        new
                        {
                            Id = 3,
                            PessoaId = 4,
                            Valor = 100.00m
                        },
                        new
                        {
                            Id = 4,
                            PessoaId = 1,
                            Valor = -50.00m
                        },
                        new
                        {
                            Id = 5,
                            PessoaId = 5,
                            Valor = -16.67m
                        });
                });

            modelBuilder.Entity("RachaConta.Models.Compra", b =>
                {
                    b.HasOne("RachaConta.Models.DiaEvento", "DiaEvento")
                        .WithMany("Compras")
                        .HasForeignKey("DiaEventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaEvento");
                });

            modelBuilder.Entity("RachaConta.Models.CompraParticipante", b =>
                {
                    b.HasOne("RachaConta.Models.Compra", "Compra")
                        .WithMany("Participantes")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RachaConta.Models.Pessoa", "Pessoa")
                        .WithMany("Compras")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("RachaConta.Models.DiaEvento", b =>
                {
                    b.HasOne("RachaConta.Models.Evento", "Evento")
                        .WithMany("Dias")
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("RachaConta.Models.Divisao", b =>
                {
                    b.HasOne("RachaConta.Models.Compra", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RachaConta.Models.Pessoa", "Credor")
                        .WithMany("CredorDivisoes")
                        .HasForeignKey("CredorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RachaConta.Models.Pessoa", "Devedor")
                        .WithMany("DevedorDivisoes")
                        .HasForeignKey("DevedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Credor");

                    b.Navigation("Devedor");
                });

            modelBuilder.Entity("RachaConta.Models.EventoPessoa", b =>
                {
                    b.HasOne("RachaConta.Models.DiaEvento", "DiaEvento")
                        .WithMany("Participantes")
                        .HasForeignKey("DiaEventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RachaConta.Models.Pessoa", "Pessoa")
                        .WithMany("Eventos")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaEvento");

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("RachaConta.Models.Pagamento", b =>
                {
                    b.HasOne("RachaConta.Models.Compra", "Compra")
                        .WithMany("Pagamentos")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RachaConta.Models.Pessoa", "Pagante")
                        .WithMany("Pagamentos")
                        .HasForeignKey("PaganteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Pagante");
                });

            modelBuilder.Entity("RachaConta.Models.Saldo", b =>
                {
                    b.HasOne("RachaConta.Models.Pessoa", "Pessoa")
                        .WithMany()
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("RachaConta.Models.Compra", b =>
                {
                    b.Navigation("Pagamentos");

                    b.Navigation("Participantes");
                });

            modelBuilder.Entity("RachaConta.Models.DiaEvento", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Participantes");
                });

            modelBuilder.Entity("RachaConta.Models.Evento", b =>
                {
                    b.Navigation("Dias");
                });

            modelBuilder.Entity("RachaConta.Models.Pessoa", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("CredorDivisoes");

                    b.Navigation("DevedorDivisoes");

                    b.Navigation("Eventos");

                    b.Navigation("Pagamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
