﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendaVerde.Models;

namespace VendaVerde.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221122024603_addNovosProdutos")]
    partial class addNovosProdutos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("VendaVerde.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaNome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaID");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            CategoriaID = 1,
                            CategoriaNome = "Frutas"
                        },
                        new
                        {
                            CategoriaID = 2,
                            CategoriaNome = "Verduras"
                        },
                        new
                        {
                            CategoriaID = 3,
                            CategoriaNome = "Grãos"
                        },
                        new
                        {
                            CategoriaID = 4,
                            CategoriaNome = "Raízes"
                        });
                });

            modelBuilder.Entity("VendaVerde.Models.DetalhePedido", b =>
                {
                    b.Property<int>("DetalhePedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("DetalhePedidoId");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("DetalhePedidos");
                });

            modelBuilder.Entity("VendaVerde.Models.ItemCarrinho", b =>
                {
                    b.Property<int>("ItemCarrinhoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarrinhoId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("ItemCarrinhoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ItensCarrinho");
                });

            modelBuilder.Entity("VendaVerde.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<decimal>("TotalPedido")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("VendaVerde.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagemUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaisInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            ProdutoId = 1,
                            CategoriaID = 1,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-5.jpg",
                            MaisInfo = "Fonte de licopeno – um composto que ajuda em problemas como inflamação e coagulação do sangue, reduzindo o risco de derrames.",
                            Nome = "Tomate Cereja",
                            Preco = 8.50m
                        },
                        new
                        {
                            ProdutoId = 2,
                            CategoriaID = 2,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-13.jpg",
                            MaisInfo = "Alface Americana",
                            Nome = "Alface",
                            Preco = 2.00m
                        },
                        new
                        {
                            ProdutoId = 3,
                            CategoriaID = 4,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-7.jpg",
                            MaisInfo = "Cenoura laranja tem substância antioxidante que faz bem para a pele e sistema imunológico",
                            Nome = "Cenoura",
                            Preco = 3.75m
                        },
                        new
                        {
                            ProdutoId = 4,
                            CategoriaID = 1,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-10.jpg",
                            MaisInfo = "Ajuda a reduzir os níveis de colesterol no sangue. Além disso, os polifenóis em sua composição têm efeito antioxidante, ajudando a diminuir a pressão arterial.",
                            Nome = "Maçã",
                            Preco = 4.80m
                        },
                        new
                        {
                            ProdutoId = 5,
                            CategoriaID = 3,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-14.jpg",
                            MaisInfo = "Rica em antioxidantes, que ajudam a proteger o organismo e prevenir algumas doenças crônicas, como o câncer.",
                            Nome = "Soja",
                            Preco = 3.49m
                        },
                        new
                        {
                            ProdutoId = 6,
                            CategoriaID = 4,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-15.jpg",
                            MaisInfo = "Melhora o funcionamento do intestino, redução de inflamações e fortalecimento do sistema imune.",
                            Nome = "Macaxeira",
                            Preco = 7.65m
                        },
                        new
                        {
                            ProdutoId = 7,
                            CategoriaID = 2,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-3.jpg",
                            MaisInfo = "Ajudam a controlar os níveis de glicemia e colesterol no sangue",
                            Nome = "Ervilha",
                            Preco = 3.50m
                        },
                        new
                        {
                            ProdutoId = 8,
                            CategoriaID = 2,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-4.jpg",
                            MaisInfo = "Melhora a digestão, graças às fibras solúveis e reduzem os níveis de colesterol ruim.",
                            Nome = "Repolho Inteiro",
                            Preco = 5.00m
                        },
                        new
                        {
                            ProdutoId = 9,
                            CategoriaID = 2,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-9.jpg",
                            MaisInfo = "Possui propriedades antivirais, antifúngicas, antibacterianas, anti-inflamatórias, anticancerígenas, hipoglicemiantes e antioxidantes.",
                            Nome = "Cebola",
                            Preco = 4.25m
                        },
                        new
                        {
                            ProdutoId = 10,
                            CategoriaID = 4,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-16.jpg",
                            MaisInfo = "Possui fósforo, ferro, potássio e cálcio, que dão mais força à musculatura e aos ossos do corpo.",
                            Nome = "Batata",
                            Preco = 3.55m
                        },
                        new
                        {
                            ProdutoId = 11,
                            CategoriaID = 1,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-2.jpg",
                            MaisInfo = "Rica em vitamina C, potássio e compostos antioxidantes.",
                            Nome = "Morango",
                            Preco = 7.00m
                        },
                        new
                        {
                            ProdutoId = 12,
                            CategoriaID = 1,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-17.jpg",
                            MaisInfo = "Rica em vitamina C, vitamina A, licopeno (responsável pela coloração da polpa vermelha) , sais minerais como cálcio, entre outros compostos que proporcionam benefícios como prevenção de câncer, estresse oxidativo, inflamação, entre outros.",
                            Nome = "Melancia Inteira",
                            Preco = 8.90m
                        },
                        new
                        {
                            ProdutoId = 13,
                            CategoriaID = 1,
                            Descricao = "12 unidades",
                            ImagemUrl = "/images/product-18.jpg",
                            MaisInfo = "Rica em potássio, um mineral importante para todas as nossas células, que regula os batimentos cardíacos e garante o funcionamento dos músculos e nervos do corpo todo, inclusive do coração.",
                            Nome = "Banana",
                            Preco = 4.30m
                        },
                        new
                        {
                            ProdutoId = 14,
                            CategoriaID = 3,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-23.jpg",
                            MaisInfo = "Ricos em nutrientes importantes para a saúde, como vitaminas do complexo B, ferro, zinco, magnésio, fósforo, proteínas, carboidratos, fibras, além de antioxidantes",
                            Nome = "Granola",
                            Preco = 5.00m
                        },
                        new
                        {
                            ProdutoId = 15,
                            CategoriaID = 3,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-24.jpg",
                            MaisInfo = "Ajuda a controlar os níveis de açúcar no sangue, o que ativa o metabolismo, auxiliando na perda de gordura.",
                            Nome = "Amendoim",
                            Preco = 7.45m
                        },
                        new
                        {
                            ProdutoId = 16,
                            CategoriaID = 3,
                            Descricao = "1kg",
                            ImagemUrl = "/images/product-25.jpg",
                            MaisInfo = "Rica em gorduras saudáveis, vitaminas, proteínas e minerais, que ajuda a manter a saúde intestinal, facilita o ganho de massa muscular e fortalece os ossos, além de outros benefícios.",
                            Nome = "Chia",
                            Preco = 7.49m
                        },
                        new
                        {
                            ProdutoId = 17,
                            CategoriaID = 1,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-19.jpg",
                            MaisInfo = "Prevenção e combate contra o câncer e suporte ao sistema imunológico",
                            Nome = "Maracujá",
                            Preco = 1.00m
                        },
                        new
                        {
                            ProdutoId = 18,
                            CategoriaID = 4,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-26.jpg",
                            MaisInfo = "Rica em açúcar, proteínas, vitamina A, B1, B2, B5, C, potássio, sódio, fósforo, cálcio, zinco, ferro e manganês.",
                            Nome = "Beterraba",
                            Preco = 0.80m
                        },
                        new
                        {
                            ProdutoId = 19,
                            CategoriaID = 2,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-21.jpg",
                            MaisInfo = "Rico em vitamina A, B1, B2, B3 e C, ele ainda conta com ácido fólico, que é um forte aliado do cérebro, faz bem ao coração, pele, unhas e cabelos, previne o câncer e melhora a imunidade.",
                            Nome = "Coentro",
                            Preco = 1.50m
                        },
                        new
                        {
                            ProdutoId = 20,
                            CategoriaID = 2,
                            Descricao = "Unidade",
                            ImagemUrl = "/images/product-22.jpg",
                            MaisInfo = "Fonte de vitaminas A e C, assim como o ferro. ",
                            Nome = "Salsa",
                            Preco = 3.00m
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VendaVerde.Models.DetalhePedido", b =>
                {
                    b.HasOne("VendaVerde.Models.Pedido", "Pedido")
                        .WithMany("DetalhePedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VendaVerde.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("VendaVerde.Models.ItemCarrinho", b =>
                {
                    b.HasOne("VendaVerde.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("VendaVerde.Models.Produto", b =>
                {
                    b.HasOne("VendaVerde.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}