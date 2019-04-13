using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AppEjemplo.Migrations
{
    public partial class ClaimsInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "claims",
                columns: table => new
                {
                    claim_id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PracticeAssociationId = table.Column<int>(nullable: false),
                    ClaimStatus = table.Column<short>(nullable: true),
                    ClaimType = table.Column<short>(nullable: false),
                    RelatedClaimId = table.Column<int>(nullable: true),
                    IsEpsdt = table.Column<bool>(nullable: false),
                    AuthorizationNumber = table.Column<string>(nullable: true),
                    insurer_id = table.Column<int>(nullable: true),
                    insurer_name = table.Column<string>(maxLength: 80, nullable: false),
                    insurer_address1 = table.Column<string>(maxLength: 55, nullable: false),
                    insurer_address2 = table.Column<string>(maxLength: 55, nullable: true),
                    insurer_city = table.Column<string>(maxLength: 50, nullable: false),
                    insurer_state = table.Column<string>(type: "character(2)", nullable: false),
                    insurer_zip = table.Column<string>(type: "character(12)", nullable: false),
                    subscriber_first_name = table.Column<string>(maxLength: 35, nullable: false),
                    subscriber_last_name = table.Column<string>(maxLength: 60, nullable: false),
                    subscriber_middle_initial = table.Column<char>(nullable: true),
                    subscriber_name_suffix = table.Column<string>(maxLength: 10, nullable: true),
                    subscriber_address1 = table.Column<string>(maxLength: 55, nullable: false),
                    subscriber_address2 = table.Column<string>(maxLength: 55, nullable: true),
                    subscriber_city = table.Column<string>(maxLength: 50, nullable: false),
                    subscriber_state = table.Column<string>(type: "character(2)", nullable: false),
                    subscriber_zip = table.Column<string>(type: "character(12)", nullable: false),
                    subscriber_d_o_b = table.Column<DateTime>(type: "date", nullable: false),
                    subscriber_gender = table.Column<char>(nullable: false),
                    subscriber_plan_group_number = table.Column<string>(maxLength: 20, nullable: false),
                    subscriber_employer_name = table.Column<string>(maxLength: 80, nullable: false),
                    subscriber_id = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_claims", x => x.claim_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "claims");
        }
    }
}
