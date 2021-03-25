using Microsoft.EntityFrameworkCore.Migrations;

namespace BerrasBio.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WhenMovieStarts = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailableSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MovieDetails",
                columns: new[] { "Id", "AvailableSeats", "MovieName", "WhenMovieStarts" },
                values: new object[,]
                {
                    { 30, 29, "Forrest Gump", "15:45" },
                    { 2, 12, "The Hateful Eight", "20:00" },
                    { 3, 55, "Catch Me If You Can", "12:00" },
                    { 4, 23, "The Conjuring", "21:30" },
                    { 5, 19, "Tenet", "18:45" },
                    { 6, 45, "Min Pappa Marianne", "19:00" },
                    { 7, 9, "American Pie", "20:30" },
                    { 8, 4, "Parasit", "22:15" },
                    { 9, 95, "Mamma Mia!", "11:00" },
                    { 10, 34, "Avengers", "18:30" },
                    { 11, 39, "Det Sociala Arvet", "17:45" },
                    { 12, 10, "The Conjuring 2", "22:00" },
                    { 13, 37, "Searching for Sugar Man", "15:00" },
                    { 14, 5, "John Wick", "20:00" },
                    { 15, 44, "The Invisible Man", "19:15" },
                    { 16, 0, "Joker", "21:00" },
                    { 17, 20, "Get Out", "21:30" },
                    { 18, 69, "The Revenant", "16:00" },
                    { 19, 47, "Manchester By The Sea", "13:00" },
                    { 20, 18, "La La Land", "14:45" },
                    { 21, 78, "The Big Short", "17:00" },
                    { 22, 40, "Toy Story", "13:30" },
                    { 23, 27, "Three Billboards Outside Ebbing, Missouri", "18:30" },
                    { 24, 33, "Amy", "19:00" },
                    { 25, 0, "Gladiator", "20:30" },
                    { 26, 15, "Lord Of The Rings", "18:00" },
                    { 27, 53, "The Departed", "21:45" },
                    { 28, 73, "Slumdog Millionaire", "17:00" },
                    { 1, 73, "Titanic", "15:30" },
                    { 29, 7, "12 Years A Slave", "18:30" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "MovieName" },
                values: new object[,]
                {
                    { 30, "Comedy", "Forrest Gump" },
                    { 28, "Drama", "Slumdog Millionaire" },
                    { 2, "Crime", "The Hateful Eight" },
                    { 3, "Biography", "Catch Me If You Can" },
                    { 4, "Horror", "The Conjuring" },
                    { 5, "Action", "Tenet" },
                    { 6, "Drama", "Min Pappa Marianne" },
                    { 7, "Comedy", "American Pie" },
                    { 8, "Thriller", "Parasit" },
                    { 9, "Romantic", "Mamma Mia!" },
                    { 10, "Sci-Fi", "Avengers" },
                    { 11, "Documentary", "Det Sociala Arvet" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Genre", "MovieName" },
                values: new object[,]
                {
                    { 12, "Horror", "The Conjuring 2" },
                    { 13, "Documentary", "Searching for Sugar Man" },
                    { 29, "Biography", "12 Years A Slave" },
                    { 14, "Thriller", "John Wick" },
                    { 16, "Drama", "Joker" },
                    { 17, "Horror", "Get Out" },
                    { 18, "Thriller", "The Revenant" },
                    { 19, "Drama", "Manchester By The Sea" },
                    { 20, "Musical", "La La Land" },
                    { 21, "Drama", "The Big Short" },
                    { 22, "Family", "Toy Story" },
                    { 23, "Crime", "Three Billboards Outside Ebbing, Missouri" },
                    { 24, "Documentary", "Amy" },
                    { 25, "Action", "Gladiator" },
                    { 26, "Sci-Fi", "Lord Of The Rings" },
                    { 27, "Crime", "The Departed" },
                    { 15, "Sci-Fi", "The Invisible Man" },
                    { 1, "Romantic", "Titanic" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDetails");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
