﻿// <auto-generated />
using System;
using ApiAgroCare.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiAgroCare.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20240908203648_fourteen")]
    partial class fourteen
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApiAgroCare.Model.Avaliacoes+AgrocareAvaliacao", b =>
                {
                    b.Property<long>("IdAvaliacoes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdAvaliacoes"));

                    b.Property<long>("ConsultaID")
                        .HasColumnType("NUMBER(19)");

                    b.Property<DateTime>("DataAvaliacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("MsgAvaliacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("QtdEstrelas")
                        .HasColumnType("NUMBER(10)");

                    b.Property<long>("UserID")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("VeterinarioID")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("IdAvaliacoes");

                    b.HasIndex("ConsultaID")
                        .IsUnique();

                    b.HasIndex("UserID");

                    b.HasIndex("VeterinarioID");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Boi", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("ConsultaID")
                        .HasColumnType("NUMBER(19)");

                    b.Property<double>("Saude")
                        .HasColumnType("BINARY_DOUBLE");

                    b.Property<int>("SaudeBoi")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("UltimoDiaAtualizacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<long>("UserID")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaID")
                        .IsUnique()
                        .HasFilter("\"ConsultaID\" IS NOT NULL");

                    b.HasIndex("UserID");

                    b.ToTable("T_AGROCARE_BOVINO");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Consulta", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("IdBoi")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("IdUser")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("IdVeterinario")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("Observacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ID");

                    b.HasIndex("IdUser");

                    b.HasIndex("IdVeterinario");

                    b.ToTable("T_AGROCARE_CONSULTAS");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Tratamento", b =>
                {
                    b.Property<long>("IdTratamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdTratamento"));

                    b.Property<long>("ConsultaID")
                        .HasColumnType("NUMBER(19)");

                    b.Property<DateTime>("DataTratamento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("DescricaoTratamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<decimal>("DoseMedicamentoML")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("DuracaoTratamento")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("EfeitoTratamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("Idboi")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("NomeMedicamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("ObservacaoTratamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("TipoTratamento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("UserID")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("VeterinarioID")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("ViaAdministracao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdTratamento");

                    b.HasIndex("ConsultaID");

                    b.HasIndex("Idboi");

                    b.HasIndex("UserID");

                    b.HasIndex("VeterinarioID");

                    b.ToTable("T_AGROCARE_TRATAMENTO");
                });

            modelBuilder.Entity("ApiAgroCare.Model.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("Number")
                        .HasColumnType("NUMBER(19)");

                    b.Property<int>("NumerosAnimais")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Planos")
                        .HasColumnType("NUMBER(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("NUMBER(1)");

                    b.HasKey("ID");

                    b.ToTable("T_AGROCARE_AGROPECUARISTA");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Veterinario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NumCrmv")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<long>("Telefone")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.ToTable("T_AGROCARE_VETERINARIO");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Avaliacoes+AgrocareAvaliacao", b =>
                {
                    b.HasOne("ApiAgroCare.Model.Consulta", "Consulta")
                        .WithOne("Avaliacoes")
                        .HasForeignKey("ApiAgroCare.Model.Avaliacoes+AgrocareAvaliacao", "ConsultaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgroCare.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgroCare.Model.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consulta");

                    b.Navigation("User");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Boi", b =>
                {
                    b.HasOne("ApiAgroCare.Model.Consulta", "Consultas")
                        .WithOne("Boi")
                        .HasForeignKey("ApiAgroCare.Model.Boi", "ConsultaID");

                    b.HasOne("ApiAgroCare.Model.User", "UserDono")
                        .WithMany("Bois")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultas");

                    b.Navigation("UserDono");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Consulta", b =>
                {
                    b.HasOne("ApiAgroCare.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgroCare.Model.Veterinario", "Veterinario")
                        .WithMany("Consultas")
                        .HasForeignKey("IdVeterinario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Tratamento", b =>
                {
                    b.HasOne("ApiAgroCare.Model.Consulta", "Consulta")
                        .WithMany()
                        .HasForeignKey("ConsultaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgroCare.Model.Boi", "Boi")
                        .WithMany()
                        .HasForeignKey("Idboi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgroCare.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiAgroCare.Model.Veterinario", "Veterinario")
                        .WithMany()
                        .HasForeignKey("VeterinarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Boi");

                    b.Navigation("Consulta");

                    b.Navigation("User");

                    b.Navigation("Veterinario");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Consulta", b =>
                {
                    b.Navigation("Avaliacoes")
                        .IsRequired();

                    b.Navigation("Boi")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiAgroCare.Model.User", b =>
                {
                    b.Navigation("Bois");
                });

            modelBuilder.Entity("ApiAgroCare.Model.Veterinario", b =>
                {
                    b.Navigation("Consultas");
                });
#pragma warning restore 612, 618
        }
    }
}
