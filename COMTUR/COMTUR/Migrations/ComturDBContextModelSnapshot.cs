﻿// <auto-generated />
using System;
using COMTUR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace COMTUR.Migrations
{
    [DbContext(typeof(ComturDBContext))]
    partial class ComturDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("COMTUR.Models.AnuncioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("anuncioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DescricaoAnuncio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("DescricaoAnuncio");

                    b.Property<int?>("EmpresaModelId")
                        .HasColumnType("integer");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<int>("IdTipoTurismo")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .HasColumnType("text")
                        .HasColumnName("imagemAnuncio");

                    b.Property<string>("Legenda")
                        .HasColumnType("text")
                        .HasColumnName("legendaAnuncio");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nomeEmpresa");

                    b.Property<int?>("TipoTurismoModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaModelId");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdTipoTurismo");

                    b.HasIndex("TipoTurismoModelId");

                    b.ToTable("anuncio");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("atracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<int>("IdTipoAtracao")
                        .HasColumnType("integer");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nome");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("qrcode");

                    b.Property<int?>("TipoAtracaoModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoAtracao");

                    b.HasIndex("TipoAtracaoModelId");

                    b.ToTable("atracao");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("empresaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("CNPJ")
                        .HasColumnType("bigint")
                        .HasColumnName("cnpj");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descricao");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("endereco");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.Property<string>("Imagem")
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("empresa");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemAtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagematracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdAtracao")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.HasKey("Id");

                    b.HasIndex("IdAtracao");

                    b.ToTable("imagematracao");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemEmpresaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagemempresaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.HasKey("Id");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("imagemempresa");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemNoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagemnoticiaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdNoticia")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.HasKey("Id");

                    b.HasIndex("IdNoticia");

                    b.ToTable("imagemnoticia");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemTurismoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("imagemTurismoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("IdTurismo")
                        .HasColumnType("integer");

                    b.Property<string>("Imagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("imagem");

                    b.Property<string>("LegendaImagem")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("legendaImagem");

                    b.HasKey("Id");

                    b.ToTable("imagemturismo");
                });

            modelBuilder.Entity("COMTUR.Models.NoticiaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("noticiaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Conteudo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("conteudo");

                    b.Property<DateOnly>("DataPublicacao")
                        .HasColumnType("date")
                        .HasColumnName("datapublicacao");

                    b.Property<string>("HoraPublicacao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("horaPublicacao");

                    b.Property<string>("Subtitulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("subtitulo");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("titulo");

                    b.HasKey("Id");

                    b.ToTable("noticia");
                });

            modelBuilder.Entity("COMTUR.Models.SessaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("idssessao");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emailusuario");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer");

                    b.Property<string>("NivelAcesso")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nivelacesso");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("nomeusuario");

                    b.Property<bool>("StatusSessao")
                        .HasColumnType("boolean")
                        .HasColumnName("statussessao");

                    b.Property<string>("TokenSessao")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("tokensessao");

                    b.Property<int?>("UsuarioModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioModelId");

                    b.ToTable("sessao");
                });

            modelBuilder.Entity("COMTUR.Models.TipoAtracaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoatracaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipoatracao");
                });

            modelBuilder.Entity("COMTUR.Models.TipoTurismoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoturismoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.HasKey("Id");

                    b.ToTable("tipoturismo");
                });

            modelBuilder.Entity("COMTUR.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("emailUsuario");

                    b.Property<string>("ImagemPerfilUsuario")
                        .HasColumnType("text")
                        .HasColumnName("imagemPerfilUsuario");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("senhaUsuario");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("telefone");

                    b.Property<int>("TipoUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("tipoUsuario");

                    b.HasKey("Id");

                    b.ToTable("usuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailUsuario = "usuario@gmail.com",
                            Nome = "Usuário",
                            SenhaUsuario = "123456",
                            Telefone = "(11) 11111-1111",
                            TipoUsuario = 1
                        },
                        new
                        {
                            Id = 2,
                            EmailUsuario = "funcionario@gmail.com",
                            Nome = "Funcionário",
                            SenhaUsuario = "123456",
                            Telefone = "(22) 22222-2222",
                            TipoUsuario = 2
                        },
                        new
                        {
                            Id = 3,
                            EmailUsuario = "empresario@gmail.com",
                            Nome = "Empresário",
                            SenhaUsuario = "123456",
                            Telefone = "(33) 33333-3333",
                            TipoUsuario = 3
                        },
                        new
                        {
                            Id = 4,
                            EmailUsuario = "administrador@gmail.com",
                            Nome = "Administrador",
                            SenhaUsuario = "123456",
                            Telefone = "(44) 44444-4444",
                            TipoUsuario = 4
                        });
                });

            modelBuilder.Entity("COMTUR.Models.AnuncioModel", b =>
                {
                    b.HasOne("COMTUR.Models.EmpresaModel", null)
                        .WithMany("AnuncioEmpresa")
                        .HasForeignKey("EmpresaModelId");

                    b.HasOne("COMTUR.Models.EmpresaModel", "EmpresaModel")
                        .WithMany()
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMTUR.Models.TipoTurismoModel", "TipoTurismoModel")
                        .WithMany()
                        .HasForeignKey("IdTipoTurismo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMTUR.Models.TipoTurismoModel", null)
                        .WithMany("Anuncios")
                        .HasForeignKey("TipoTurismoModelId");

                    b.Navigation("EmpresaModel");

                    b.Navigation("TipoTurismoModel");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.HasOne("COMTUR.Models.TipoAtracaoModel", "TipoAtracaoModel")
                        .WithMany()
                        .HasForeignKey("IdTipoAtracao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("COMTUR.Models.TipoAtracaoModel", null)
                        .WithMany("Atracao")
                        .HasForeignKey("TipoAtracaoModelId");

                    b.Navigation("TipoAtracaoModel");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.HasOne("COMTUR.Models.UsuarioModel", "UsuarioModel")
                        .WithMany("Empresas")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UsuarioModel");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemAtracaoModel", b =>
                {
                    b.HasOne("COMTUR.Models.AtracaoModel", "AtracaoModel")
                        .WithMany("ImagemAtracao")
                        .HasForeignKey("IdAtracao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AtracaoModel");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemEmpresaModel", b =>
                {
                    b.HasOne("COMTUR.Models.EmpresaModel", "EmpresaModel")
                        .WithMany("ImagemEmpresa")
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmpresaModel");
                });

            modelBuilder.Entity("COMTUR.Models.ImagemNoticiaModel", b =>
                {
                    b.HasOne("COMTUR.Models.NoticiaModel", "NoticiaModel")
                        .WithMany("ImagemNoticia")
                        .HasForeignKey("IdNoticia")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NoticiaModel");
                });

            modelBuilder.Entity("COMTUR.Models.SessaoModel", b =>
                {
                    b.HasOne("COMTUR.Models.UsuarioModel", "UsuarioModel")
                        .WithMany()
                        .HasForeignKey("UsuarioModelId");

                    b.Navigation("UsuarioModel");
                });

            modelBuilder.Entity("COMTUR.Models.AtracaoModel", b =>
                {
                    b.Navigation("ImagemAtracao");
                });

            modelBuilder.Entity("COMTUR.Models.EmpresaModel", b =>
                {
                    b.Navigation("AnuncioEmpresa");

                    b.Navigation("ImagemEmpresa");
                });

            modelBuilder.Entity("COMTUR.Models.NoticiaModel", b =>
                {
                    b.Navigation("ImagemNoticia");
                });

            modelBuilder.Entity("COMTUR.Models.TipoAtracaoModel", b =>
                {
                    b.Navigation("Atracao");
                });

            modelBuilder.Entity("COMTUR.Models.TipoTurismoModel", b =>
                {
                    b.Navigation("Anuncios");
                });

            modelBuilder.Entity("COMTUR.Models.UsuarioModel", b =>
                {
                    b.Navigation("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}
