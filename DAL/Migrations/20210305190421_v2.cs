using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_PersonInfos_PersonID",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_PersonInfos_PersonID",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PersonInfos_PersonID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Portofolios_PersonInfos_PersonID",
                table: "Portofolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_PersonInfos_PersonID",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_PersonInfos_PersonID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_PersonInfos_PersonID",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_PersonID",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PersonID",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Services_PersonID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Portofolios_PersonID",
                table: "Portofolios");

            migrationBuilder.DropIndex(
                name: "IX_Images_PersonID",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_PersonID",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_Educations_PersonID",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Portofolios");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "PersonID",
                table: "Educations");

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "Portofolios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "Experiences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonInfoID",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PersonInfoID",
                table: "SocialMedias",
                column: "PersonInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersonInfoID",
                table: "Skills",
                column: "PersonInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_PersonInfoID",
                table: "Services",
                column: "PersonInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Portofolios_PersonInfoID",
                table: "Portofolios",
                column: "PersonInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PersonInfoID",
                table: "Images",
                column: "PersonInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PersonInfoID",
                table: "Experiences",
                column: "PersonInfoID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonInfoID",
                table: "Educations",
                column: "PersonInfoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_PersonInfos_PersonInfoID",
                table: "Educations",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_PersonInfos_PersonInfoID",
                table: "Experiences",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PersonInfos_PersonInfoID",
                table: "Images",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Portofolios_PersonInfos_PersonInfoID",
                table: "Portofolios",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_PersonInfos_PersonInfoID",
                table: "Services",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_PersonInfos_PersonInfoID",
                table: "Skills",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_PersonInfos_PersonInfoID",
                table: "SocialMedias",
                column: "PersonInfoID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_PersonInfos_PersonInfoID",
                table: "Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiences_PersonInfos_PersonInfoID",
                table: "Experiences");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_PersonInfos_PersonInfoID",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Portofolios_PersonInfos_PersonInfoID",
                table: "Portofolios");

            migrationBuilder.DropForeignKey(
                name: "FK_Services_PersonInfos_PersonInfoID",
                table: "Services");

            migrationBuilder.DropForeignKey(
                name: "FK_Skills_PersonInfos_PersonInfoID",
                table: "Skills");

            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_PersonInfos_PersonInfoID",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_PersonInfoID",
                table: "SocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_Skills_PersonInfoID",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Services_PersonInfoID",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Portofolios_PersonInfoID",
                table: "Portofolios");

            migrationBuilder.DropIndex(
                name: "IX_Images_PersonInfoID",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Experiences_PersonInfoID",
                table: "Experiences");

            migrationBuilder.DropIndex(
                name: "IX_Educations_PersonInfoID",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "Portofolios");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "Experiences");

            migrationBuilder.DropColumn(
                name: "PersonInfoID",
                table: "Educations");

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "SocialMedias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Skills",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Portofolios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Images",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Experiences",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonID",
                table: "Educations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_PersonID",
                table: "SocialMedias",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_PersonID",
                table: "Skills",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_PersonID",
                table: "Services",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Portofolios_PersonID",
                table: "Portofolios",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PersonID",
                table: "Images",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_PersonID",
                table: "Experiences",
                column: "PersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonID",
                table: "Educations",
                column: "PersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_PersonInfos_PersonID",
                table: "Educations",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiences_PersonInfos_PersonID",
                table: "Experiences",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_PersonInfos_PersonID",
                table: "Images",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Portofolios_PersonInfos_PersonID",
                table: "Portofolios",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Services_PersonInfos_PersonID",
                table: "Services",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_PersonInfos_PersonID",
                table: "Skills",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_PersonInfos_PersonID",
                table: "SocialMedias",
                column: "PersonID",
                principalTable: "PersonInfos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
