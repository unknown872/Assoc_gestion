using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace appli_gest_assoc.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "activites",
                columns: table => new
                {
                    id_activite = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_activites", x => x.id_activite);
                });

            migrationBuilder.CreateTable(
                name: "associations",
                columns: table => new
                {
                    id_association = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_association = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    annee_creation = table.Column<DateTime>(type: "datetime", nullable: false),
                    tel1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tel2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_associations", x => x.id_association);
                });

            migrationBuilder.CreateTable(
                name: "membres",
                columns: table => new
                {
                    id_membre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    prenom_membre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nom_membre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    sexe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    date_naiss = table.Column<DateTime>(type: "datetime", nullable: false),
                    lieu_naiss = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tel = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membres", x => x.id_membre);
                });

            migrationBuilder.CreateTable(
                name: "type_depense",
                columns: table => new
                {
                    id_type_depense = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_depense", x => x.id_type_depense);
                });

            migrationBuilder.CreateTable(
                name: "type_recette",
                columns: table => new
                {
                    id_type_recette = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_recette", x => x.id_type_recette);
                });

            migrationBuilder.CreateTable(
                name: "bureau",
                columns: table => new
                {
                    id_bureau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_bureau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    date_creation = table.Column<DateTime>(type: "datetime", nullable: false),
                    association_id = table.Column<int>(type: "int", nullable: false),
                    activite_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bureau", x => x.id_bureau);
                    table.ForeignKey(
                        name: "FK_bureau_activites",
                        column: x => x.activite_id,
                        principalTable: "activites",
                        principalColumn: "id_activite",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bureau_associations",
                        column: x => x.association_id,
                        principalTable: "associations",
                        principalColumn: "id_association",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "depenses",
                columns: table => new
                {
                    id_depense = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    type_depense_id = table.Column<int>(type: "int", nullable: false),
                    montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    bureau_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_depenses", x => x.id_depense);
                    table.ForeignKey(
                        name: "FK_depenses_bureau",
                        column: x => x.bureau_id,
                        principalTable: "bureau",
                        principalColumn: "id_bureau",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_depenses_type_depense",
                        column: x => x.type_depense_id,
                        principalTable: "type_depense",
                        principalColumn: "id_type_depense",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "membre_bureau",
                columns: table => new
                {
                    id_membre_bureau = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    membre_id = table.Column<int>(type: "int", nullable: false),
                    date_creation = table.Column<DateTime>(type: "datetime", nullable: false),
                    poste = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    bureau_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_membre_bureau", x => x.id_membre_bureau);
                    table.ForeignKey(
                        name: "FK_membre_bureau_bureau",
                        column: x => x.bureau_id,
                        principalTable: "bureau",
                        principalColumn: "id_bureau",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_membre_bureau_membre",
                        column: x => x.membre_id,
                        principalTable: "membres",
                        principalColumn: "id_membre",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "recettes",
                columns: table => new
                {
                    id_recette = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    libelle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    type_recette_id = table.Column<int>(type: "int", nullable: false),
                    montant = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    bureau_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recettes", x => x.id_recette);
                    table.ForeignKey(
                        name: "FK_recettes_bureau",
                        column: x => x.bureau_id,
                        principalTable: "bureau",
                        principalColumn: "id_bureau",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_recettes_type_recette",
                        column: x => x.type_recette_id,
                        principalTable: "type_recette",
                        principalColumn: "id_type_recette",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "Bureau_unique",
                table: "bureau",
                column: "nom_bureau",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_bureau_activite_id",
                table: "bureau",
                column: "activite_id");

            migrationBuilder.CreateIndex(
                name: "IX_bureau_association_id",
                table: "bureau",
                column: "association_id");

            migrationBuilder.CreateIndex(
                name: "IX_depenses_bureau_id",
                table: "depenses",
                column: "bureau_id");

            migrationBuilder.CreateIndex(
                name: "IX_depenses_type_depense_id",
                table: "depenses",
                column: "type_depense_id");

            migrationBuilder.CreateIndex(
                name: "IX_membre_bureau_bureau_id",
                table: "membre_bureau",
                column: "bureau_id");

            migrationBuilder.CreateIndex(
                name: "IX_membre_bureau_membre_id",
                table: "membre_bureau",
                column: "membre_id");

            migrationBuilder.CreateIndex(
                name: "IX_recettes_bureau_id",
                table: "recettes",
                column: "bureau_id");

            migrationBuilder.CreateIndex(
                name: "IX_recettes_type_recette_id",
                table: "recettes",
                column: "type_recette_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "depenses");

            migrationBuilder.DropTable(
                name: "membre_bureau");

            migrationBuilder.DropTable(
                name: "recettes");

            migrationBuilder.DropTable(
                name: "type_depense");

            migrationBuilder.DropTable(
                name: "membres");

            migrationBuilder.DropTable(
                name: "bureau");

            migrationBuilder.DropTable(
                name: "type_recette");

            migrationBuilder.DropTable(
                name: "activites");

            migrationBuilder.DropTable(
                name: "associations");
        }
    }
}
