using Microsoft.EntityFrameworkCore.Migrations;

namespace VendaVerde.Migrations
{
    public partial class addNovosProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "CategoriaID",
                value: 4);

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CategoriaID", "Descricao", "ImagemUrl", "MaisInfo", "Nome", "Preco" },
                values: new object[,]
                {
                    { 7, 2, "1kg", "/images/product-3.jpg", "Ajudam a controlar os níveis de glicemia e colesterol no sangue", "Ervilha", 3.50m },
                    { 8, 2, "Unidade", "/images/product-4.jpg", "Melhora a digestão, graças às fibras solúveis e reduzem os níveis de colesterol ruim.", "Repolho Inteiro", 5.00m },
                    { 9, 2, "1kg", "/images/product-9.jpg", "Possui propriedades antivirais, antifúngicas, antibacterianas, anti-inflamatórias, anticancerígenas, hipoglicemiantes e antioxidantes.", "Cebola", 4.25m },
                    { 10, 4, "1kg", "/images/product-16.jpg", "Possui fósforo, ferro, potássio e cálcio, que dão mais força à musculatura e aos ossos do corpo.", "Batata", 3.55m },
                    { 11, 1, "1kg", "/images/product-2.jpg", "Rica em vitamina C, potássio e compostos antioxidantes.", "Morango", 7.00m },
                    { 12, 1, "Unidade", "/images/product-17.jpg", "Rica em vitamina C, vitamina A, licopeno (responsável pela coloração da polpa vermelha) , sais minerais como cálcio, entre outros compostos que proporcionam benefícios como prevenção de câncer, estresse oxidativo, inflamação, entre outros.", "Melancia Inteira", 8.90m },
                    { 13, 1, "12 unidades", "/images/product-18.jpg", "Rica em potássio, um mineral importante para todas as nossas células, que regula os batimentos cardíacos e garante o funcionamento dos músculos e nervos do corpo todo, inclusive do coração.", "Banana", 4.30m },
                    { 14, 3, "1kg", "/images/product-23.jpg", "Ricos em nutrientes importantes para a saúde, como vitaminas do complexo B, ferro, zinco, magnésio, fósforo, proteínas, carboidratos, fibras, além de antioxidantes", "Granola", 5.00m },
                    { 15, 3, "1kg", "/images/product-24.jpg", "Ajuda a controlar os níveis de açúcar no sangue, o que ativa o metabolismo, auxiliando na perda de gordura.", "Amendoim", 7.45m },
                    { 16, 3, "1kg", "/images/product-25.jpg", "Rica em gorduras saudáveis, vitaminas, proteínas e minerais, que ajuda a manter a saúde intestinal, facilita o ganho de massa muscular e fortalece os ossos, além de outros benefícios.", "Chia", 7.49m },
                    { 17, 1, "Unidade", "/images/product-19.jpg", "Prevenção e combate contra o câncer e suporte ao sistema imunológico", "Maracujá", 1.00m },
                    { 18, 4, "Unidade", "/images/product-26.jpg", "Rica em açúcar, proteínas, vitamina A, B1, B2, B5, C, potássio, sódio, fósforo, cálcio, zinco, ferro e manganês.", "Beterraba", 0.80m },
                    { 19, 2, "Unidade", "/images/product-21.jpg", "Rico em vitamina A, B1, B2, B3 e C, ele ainda conta com ácido fólico, que é um forte aliado do cérebro, faz bem ao coração, pele, unhas e cabelos, previne o câncer e melhora a imunidade.", "Coentro", 1.50m },
                    { 20, 2, "Unidade", "/images/product-22.jpg", "Fonte de vitaminas A e C, assim como o ferro. ", "Salsa", 3.00m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "ProdutoId",
                keyValue: 3,
                column: "CategoriaID",
                value: 2);
        }
    }
}
