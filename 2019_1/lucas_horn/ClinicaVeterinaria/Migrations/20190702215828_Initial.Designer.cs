﻿// <auto-generated />
using System;
using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaVeterinaria.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaContext))]
    [Migration("20190702215828_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClinicaVeterinaria.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Altura")
                        .IsRequired();

                    b.Property<int?>("CaixaId");

                    b.Property<string>("DescricaoEspecie")
                        .HasMaxLength(60);

                    b.Property<int>("EspecieId");

                    b.Property<int>("Idade");

                    b.Property<string>("NomeAnimal")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<float>("Peso");

                    b.Property<int>("ProprietarioId");

                    b.Property<string>("Sexo")
                        .HasMaxLength(1);

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.HasIndex("EspecieId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Caixa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnimalId");

                    b.Property<int>("ConsultaId");

                    b.Property<string>("Descricao");

                    b.Property<int>("ProprietarioId");

                    b.Property<string>("Tipo");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Caixas");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro")
                        .IsRequired();

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<string>("Cidade")
                        .IsRequired();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Estado")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("Numero");

                    b.Property<string>("Rua")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnimalId");

                    b.Property<int?>("CaixaId");

                    b.Property<DateTime>("DataConsulta");

                    b.Property<int>("EspecieId");

                    b.Property<int>("MedicamentoId");

                    b.Property<int>("ProprietarioId");

                    b.Property<string>("Sintomas");

                    b.Property<double>("ValorConsulta");

                    b.Property<int>("VeterinarioId");

                    b.Property<bool>("pago");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("CaixaId");

                    b.HasIndex("EspecieId");

                    b.HasIndex("MedicamentoId");

                    b.HasIndex("ProprietarioId");

                    b.HasIndex("VeterinarioId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Especie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("NomeEspecie")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Especies");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnimalId");

                    b.Property<int?>("CaixaId");

                    b.Property<int>("EspecieId");

                    b.Property<string>("NomeDoExame")
                        .IsRequired();

                    b.Property<int>("ProprietarioId");

                    b.Property<bool>("Realizado");

                    b.Property<double>("ValorExame");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("CaixaId");

                    b.HasIndex("EspecieId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Exames");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnimalId");

                    b.Property<string>("DescricaoMedicamento")
                        .HasMaxLength(120);

                    b.Property<string>("NomeMedicamento")
                        .HasMaxLength(60);

                    b.Property<int>("ProprietarioId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Proprietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaixaId");

                    b.Property<int?>("ConsultaId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("NomeProprietario")
                        .IsRequired();

                    b.Property<string>("Telefone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CaixaId");

                    b.HasIndex("ConsultaId");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Veterinario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPF")
                        .IsRequired();

                    b.Property<string>("Celular")
                        .IsRequired();

                    b.Property<int?>("ConsultaId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("Registro");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.ToTable("Veterinarios");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Animal", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Caixa")
                        .WithMany("Animals")
                        .HasForeignKey("CaixaId");

                    b.HasOne("ClinicaVeterinaria.Models.Especie", "Especie")
                        .WithMany()
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Proprietario", "Proprietario")
                        .WithMany("Animals")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Caixa", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Proprietario", "Proprietario")
                        .WithMany()
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Consulta", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Animal", "Animal")
                        .WithMany("Consultas")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Caixa")
                        .WithMany("Consultas")
                        .HasForeignKey("CaixaId");

                    b.HasOne("ClinicaVeterinaria.Models.Especie", "Especies")
                        .WithMany()
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Medicamento", "Medicamento")
                        .WithMany()
                        .HasForeignKey("MedicamentoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Proprietario", "Proprietario")
                        .WithMany()
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Exame", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Caixa")
                        .WithMany("Exames")
                        .HasForeignKey("CaixaId");

                    b.HasOne("ClinicaVeterinaria.Models.Especie", "Especie")
                        .WithMany()
                        .HasForeignKey("EspecieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Proprietario", "Proprietario")
                        .WithMany()
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Medicamento", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ClinicaVeterinaria.Models.Proprietario", "Proprietario")
                        .WithMany()
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Proprietario", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Caixa")
                        .WithMany("Proprietarios")
                        .HasForeignKey("CaixaId");

                    b.HasOne("ClinicaVeterinaria.Models.Consulta")
                        .WithMany("Proprietarios")
                        .HasForeignKey("ConsultaId");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Veterinario", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Consulta")
                        .WithMany("Veterinarios")
                        .HasForeignKey("ConsultaId");
                });
#pragma warning restore 612, 618
        }
    }
}
