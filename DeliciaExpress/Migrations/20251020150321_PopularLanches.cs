using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeliciaExpress.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoLonga, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId)" +
                "VALUES('X-Bacon', 'Lanche com bacon e queijo', 'Delicioso lanche com pão, carne bovina, queijo cheddar, bacon crocante, alface e tomate.', 12.50, 'https://example.com/images/xbacon.jpg', 'https://example.com/images/xbacon_thumb.jpg', 1, 1, 1)");

            migrationBuilder.Sql("INSERT INTO Lanches(Nome, DescricaoCurta, DescricaoLonga, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId)" +
                "VALUES('X-Salada', 'Lanche com Hambuguer e salada', 'Delicioso lanche com pão, carne vagetariana, queijo, alface e tomate.', 12.50, 'https://example.com/images/xbacon.jpg', 'https://example.com/images/xbacon_thumb.jpg', 1, 1, 2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
