using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaVerde.Migrations
{
    public partial class SeedDataTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaID", "CategoriaNome", "Descricao" },
                values: new object[] { 1, "Frutas", "Frutas de qualidade" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaID", "CategoriaNome", "Descricao" },
                values: new object[] { 2, "Verduras", "Verduras Saborosas" });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaID", "CategoriaNome", "Descricao" },
                values: new object[] { 3, "Grãos", "Grãos Saudáveis" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "AlergiaInfo", "CategoriaID", "Descricao", "ImagemUrl", "InEstoque", "IsProdutoSemana", "MaisInfo", "Nome", "Preco", "ThumbnailUrl" },
                values: new object[,]
                {
                    { 1, null, 1, "Tomate vermelho e suculento", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, false, "Tomate do tipo cereja", "Tomate", 5.50m, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" },
                    { 4, null, 1, "Maçã docinho", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Maça importado", "Maçã", 1.10m, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" },
                    { 2, null, 2, "Alface fresca e verdinha", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", true, false, "Alface crespo", "Alface", 2.20m, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" },
                    { 3, null, 2, "Cenoura laranjinha", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", true, false, "Cenoura madura", "Cenoura", 3.70m, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 2);
        }
    }
}
