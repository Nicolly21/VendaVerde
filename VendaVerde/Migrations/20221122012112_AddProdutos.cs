using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaVerde.Migrations
{
    public partial class AddProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlergiaInfo",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "InEstoque",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "IsProdutoSemana",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ThumbnailUrl",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Categorias");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "Descricao", "ImagemUrl", "MaisInfo", "Nome", "Preco" },
                values: new object[] { "1kg", "/images/product-5.jpg", "Fonte de licopeno – um composto que ajuda em problemas como inflamação e coagulação do sangue, reduzindo o risco de derrames.", "Tomate Cereja", 8.50m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "Descricao", "ImagemUrl", "MaisInfo", "Preco" },
                values: new object[] { "Unidade", "/images/product-13.jpg", "Alface Americana", 2.00m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "Descricao", "ImagemUrl", "MaisInfo", "Preco" },
                values: new object[] { "1kg", "/images/product-7.jpg", "Cenoura laranja tem substância antioxidante que faz bem para a pele e sistema imunológico", 3.75m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "Descricao", "ImagemUrl", "MaisInfo", "Preco" },
                values: new object[] { "1kg", "/images/product-10.jpg", "Ajuda a reduzir os níveis de colesterol no sangue. Além disso, os polifenóis em sua composição têm efeito antioxidante, ajudando a diminuir a pressão arterial.", 4.80m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "ImagemUrl", "MaisInfo", "Preco" },
                values: new object[] { "/images/product-14.jpg", "Rica em antioxidantes, que ajudam a proteger o organismo e prevenir algumas doenças crônicas, como o câncer.", 3.49m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "ImagemUrl", "MaisInfo", "Preco" },
                values: new object[] { "/images/product-15.jpg", "Melhora o funcionamento do intestino, redução de inflamações e fortalecimento do sistema imune.", 7.65m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlergiaInfo",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "InEstoque",
                table: "Produtos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsProdutoSemana",
                table: "Produtos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUrl",
                table: "Produtos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 1,
                column: "Descricao",
                value: "Frutas de qualidade");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 2,
                column: "Descricao",
                value: "Verduras Saborosas");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 3,
                column: "Descricao",
                value: "Grãos Saudáveis");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaID",
                keyValue: 4,
                column: "Descricao",
                value: "Raízes fortes e nutritivas");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "Descricao", "ImagemUrl", "InEstoque", "MaisInfo", "Nome", "Preco", "ThumbnailUrl" },
                values: new object[] { "Tomate vermelho e suculento", "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", true, "Tomate do tipo cereja", "Tomate", 5.50m, "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "Descricao", "ImagemUrl", "InEstoque", "MaisInfo", "Preco", "ThumbnailUrl" },
                values: new object[] { "Alface fresca e verdinha", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", true, "Alface crespo", 2.20m, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "Descricao", "ImagemUrl", "InEstoque", "MaisInfo", "Preco", "ThumbnailUrl" },
                values: new object[] { "Cenoura laranjinha", "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg", true, "Cenoura madura", 3.70m, "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "Descricao", "ImagemUrl", "InEstoque", "MaisInfo", "Preco", "ThumbnailUrl" },
                values: new object[] { "Maçã docinho", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, "Maça importado", 1.10m, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "ImagemUrl", "InEstoque", "MaisInfo", "Preco", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, "Soja nacional", 3.40m, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "ImagemUrl", "InEstoque", "MaisInfo", "Preco", "ThumbnailUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, "Macaxeira/Mandioca", 5.50m, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg" });
        }
    }
}
