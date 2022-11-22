using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemCarrinho> ItensCarrinho { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetalhePedido> DetalhePedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Alimentando a Tabela Categoria
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 1, CategoriaNome = "Frutas"});
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 2, CategoriaNome = "Verduras" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 3, CategoriaNome = "Grãos" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 4, CategoriaNome = "Raízes"});

            //Alimentando a Tabela Produto
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 1,
                Nome = "Tomate Cereja",
                Preco = 8.50M,
                Descricao = "1kg",
                MaisInfo = "Fonte de licopeno – um composto que ajuda em problemas como inflamação e coagulação do sangue, reduzindo o risco de derrames.",
                CategoriaID = 1,
                ImagemUrl = "/images/product-5.jpg"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 2,
                Nome = "Alface",
                Preco = 2.00M,
                Descricao = "Unidade",
                MaisInfo = "Alface Americana",
                CategoriaID = 2,
                ImagemUrl = "/images/product-13.jpg"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 3,
                Nome = "Cenoura",
                Preco = 3.75M,
                Descricao = "1kg",
                MaisInfo = "Cenoura laranja tem substância antioxidante que faz bem para a pele e sistema imunológico",
                CategoriaID = 4,
                ImagemUrl = "/images/product-7.jpg"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 4,
                Nome = "Maçã",
                Preco = 4.80M,
                Descricao = "1kg",
                MaisInfo = "Ajuda a reduzir os níveis de colesterol no sangue. Além disso, os polifenóis em sua composição têm efeito antioxidante, ajudando a diminuir a pressão arterial.",
                CategoriaID = 1,
                ImagemUrl = "/images/product-10.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 5,
                Nome = "Soja",
                Preco = 3.49M,
                Descricao = "1kg",
                MaisInfo = "Rica em antioxidantes, que ajudam a proteger o organismo e prevenir algumas doenças crônicas, como o câncer.",
                CategoriaID = 3,
                ImagemUrl = "/images/product-27.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 6,
                Nome = "Macaxeira",
                Preco = 7.65M,
                Descricao = "1kg",
                MaisInfo = "Melhora o funcionamento do intestino, redução de inflamações e fortalecimento do sistema imune.",
                CategoriaID = 4,
                ImagemUrl = "/images/product-15.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 7,
                Nome = "Ervilha",
                Preco = 3.50M,
                Descricao = "1kg",
                MaisInfo = "Ajudam a controlar os níveis de glicemia e colesterol no sangue",
                CategoriaID = 2,
                ImagemUrl = "/images/product-3.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 8,
                Nome = "Repolho Inteiro",
                Preco = 5.00M,
                Descricao = "Unidade",
                MaisInfo = "Melhora a digestão, graças às fibras solúveis e reduzem os níveis de colesterol ruim.",
                CategoriaID = 2,
                ImagemUrl = "/images/product-4.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 9,
                Nome = "Cebola",
                Preco = 4.25M,
                Descricao = "1kg",
                MaisInfo = "Possui propriedades antivirais, antifúngicas, antibacterianas, anti-inflamatórias, anticancerígenas, hipoglicemiantes e antioxidantes.",
                CategoriaID = 2,
                ImagemUrl = "/images/product-9.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 10,
                Nome = "Batata",
                Preco = 3.55M,
                Descricao = "1kg",
                MaisInfo = "Possui fósforo, ferro, potássio e cálcio, que dão mais força à musculatura e aos ossos do corpo.",
                CategoriaID = 4,
                ImagemUrl = "/images/product-16.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 11,
                Nome = "Morango",
                Preco = 7.00M,
                Descricao = "1kg",
                MaisInfo = "Rica em vitamina C, potássio e compostos antioxidantes.",
                CategoriaID = 1,
                ImagemUrl = "/images/product-2.jpg",
            });
            
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 12,
                Nome = "Melancia Inteira",
                Preco = 8.90M,
                Descricao = "Unidade",
                MaisInfo = "Rica em vitamina C, vitamina A, licopeno (responsável pela coloração da polpa vermelha) , sais minerais como cálcio, entre outros compostos que proporcionam benefícios como prevenção de câncer, estresse oxidativo, inflamação, entre outros.",
                CategoriaID = 1,
                ImagemUrl = "/images/product-17.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 13,
                Nome = "Banana",
                Preco = 4.30M,
                Descricao = "12 unidades",
                MaisInfo = "Rica em potássio, um mineral importante para todas as nossas células, que regula os batimentos cardíacos e garante o funcionamento dos músculos e nervos do corpo todo, inclusive do coração.",
                CategoriaID = 1,
                ImagemUrl = "/images/product-18.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 14,
                Nome = "Granola",
                Preco = 5.00M,
                Descricao = "1kg",
                MaisInfo = "Ricos em nutrientes importantes para a saúde, como vitaminas do complexo B, ferro, zinco, magnésio, fósforo, proteínas, carboidratos, fibras, além de antioxidantes",
                CategoriaID = 3,
                ImagemUrl = "/images/product-23.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 15,
                Nome = "Amendoim",
                Preco = 7.45M,
                Descricao = "1kg",
                MaisInfo = "Ajuda a controlar os níveis de açúcar no sangue, o que ativa o metabolismo, auxiliando na perda de gordura.",
                CategoriaID = 3,
                ImagemUrl = "/images/product-24.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 16,
                Nome = "Chia",
                Preco = 7.49M,
                Descricao = "1kg",
                MaisInfo = "Rica em gorduras saudáveis, vitaminas, proteínas e minerais, que ajuda a manter a saúde intestinal, facilita o ganho de massa muscular e fortalece os ossos, além de outros benefícios.",
                CategoriaID = 3,
                ImagemUrl = "/images/product-25.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 17,
                Nome = "Maracujá",
                Preco = 1.00M,
                Descricao = "Unidade",
                MaisInfo = "Prevenção e combate contra o câncer e suporte ao sistema imunológico",
                CategoriaID = 1,
                ImagemUrl = "/images/product-19.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 18,
                Nome = "Beterraba",
                Preco = 0.80M,
                Descricao = "Unidade",
                MaisInfo = "Rica em açúcar, proteínas, vitamina A, B1, B2, B5, C, potássio, sódio, fósforo, cálcio, zinco, ferro e manganês.",
                CategoriaID = 4,
                ImagemUrl = "/images/product-26.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 19,
                Nome = "Coentro",
                Preco = 1.50M,
                Descricao = "Unidade",
                MaisInfo = "Rico em vitamina A, B1, B2, B3 e C, ele ainda conta com ácido fólico, que é um forte aliado do cérebro, faz bem ao coração, pele, unhas e cabelos, previne o câncer e melhora a imunidade.",
                CategoriaID = 2,
                ImagemUrl = "/images/product-21.jpg",
            });
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 20,
                Nome = "Salsa",
                Preco = 3.00M,
                Descricao = "Unidade",
                MaisInfo = "Fonte de vitaminas A e C, assim como o ferro. ",
                CategoriaID = 2,
                ImagemUrl = "/images/product-22.jpg",
            });
        }
    }
}
