﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClubMembershipApplication.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailAddressToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "emailAddress",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "emailAddress",
                table: "Users");
        }
    }
}
