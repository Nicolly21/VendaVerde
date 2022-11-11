using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaVerde.Migrations
{
    public partial class NovasCaregorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "CategoriaID", "CategoriaNome", "Descricao" },
                values: new object[] { 4, "Raízes", "Raízes fortes e nutritivas" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "AlergiaInfo", "CategoriaID", "Descricao", "ImagemUrl", "InEstoque", "IsProdutoSemana", "MaisInfo", "Nome", "Preco", "ThumbnailUrl" },
                values: new object[] { 5, null, 3, "1kg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Soja nacional", "Soja", 3.40m, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "AlergiaInfo", "CategoriaID", "Descricao", "ImagemUrl", "InEstoque", "IsProdutoSemana", "MaisInfo", "Nome", "Preco", "ThumbnailUrl" },
                values: new object[] { 6, null, 4, "1kg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "Macaxeira/Mandioca", "Macaxeira", 5.50m, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 4);
        }
    }
}
