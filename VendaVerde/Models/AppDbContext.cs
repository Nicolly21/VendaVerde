﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VendaVerde.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Alimentando a Tabela Categoria
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 1, CategoriaNome = "Frutas", Descricao = "Frutas de qualidade" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 2, CategoriaNome = "Verduras", Descricao = "Verduras Saborosas" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { CategoriaID = 3, CategoriaNome = "Grãos", Descricao = "Grãos Saudáveis" });

            //Alimentando a Tabela Produto
            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 1,
                Nome = "Tomate",
                Preco = 5.50M,
                Descricao = "Tomate vermelho e suculento",
                MaisInfo = "Tomate do tipo cereja",
                CategoriaID = 1,
                ImagemUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                InEstoque = true,
                IsProdutoSemana = false,
                ThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 2,
                Nome = "Alface",
                Preco = 2.20M,
                Descricao = "Alface fresca e verdinha",
                MaisInfo = "Alface crespo",
                CategoriaID = 2,
                ImagemUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                InEstoque = true,
                IsProdutoSemana = false,
                ThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 3,
                Nome = "Cenoura",
                Preco = 3.70M,
                Descricao = "Cenoura laranjinha",
                MaisInfo = "Cenoura madura",
                CategoriaID = 2,
                ImagemUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                InEstoque = true,
                IsProdutoSemana = false,
                ThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg"
            });

            modelBuilder.Entity<Produto>().HasData(new Produto
            {
                ProdutoId = 4,
                Nome = "Maçã",
                Preco = 1.10M,
                Descricao = "Maçã docinho",
                MaisInfo = "Maça importado",
                CategoriaID = 1,
                ImagemUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                InEstoque = true,
                IsProdutoSemana = false,
                ThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg"
            });
        }
    }
}