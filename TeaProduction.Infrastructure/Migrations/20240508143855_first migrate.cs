using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TeaProduction.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class firstmigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TeaName = table.Column<string>(type: "text", nullable: false),
                    TeaType = table.Column<string>(type: "text", nullable: false),
                    ProductionCountry = table.Column<string>(type: "text", nullable: false),
                    TeaPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    StartExpireDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndExpireDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    MachineId = table.Column<int>(type: "integer", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ModifyDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DeletedDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teas");
        }
    }
}
