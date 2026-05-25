using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bidirectional.DomainCore.Migrations
{
    /// <inheritdoc />
    public partial class AuditLogJsonPayloadConstraints : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_AuditLogs_ChangedKeyValues_CHARSET",
                table: "AuditLogs");

            migrationBuilder.DropCheckConstraint(
                name: "CK_AuditLogDetails_NewValue_CHARSET",
                table: "AuditLogDetails");

            migrationBuilder.DropCheckConstraint(
                name: "CK_AuditLogDetails_OldValue_CHARSET",
                table: "AuditLogDetails");

            migrationBuilder.AlterColumn<string>(
                name: "ChangedKeyValues",
                table: "AuditLogs",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OldValue",
                table: "AuditLogDetails",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NewValue",
                table: "AuditLogDetails",
                type: "nvarchar(4000)",
                maxLength: 4000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldUnicode: false,
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_AuditLogs_ChangedKeyValues_JSON",
                table: "AuditLogs",
                sql: "ISJSON([ChangedKeyValues]) = 1");

            migrationBuilder.AddCheckConstraint(
                name: "CK_AuditLogDetails_NewValue_JSON",
                table: "AuditLogDetails",
                sql: "ISJSON([NewValue]) = 1");

            migrationBuilder.AddCheckConstraint(
                name: "CK_AuditLogDetails_OldValue_JSON",
                table: "AuditLogDetails",
                sql: "ISJSON([OldValue]) = 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_AuditLogs_ChangedKeyValues_JSON",
                table: "AuditLogs");

            migrationBuilder.DropCheckConstraint(
                name: "CK_AuditLogDetails_NewValue_JSON",
                table: "AuditLogDetails");

            migrationBuilder.DropCheckConstraint(
                name: "CK_AuditLogDetails_OldValue_JSON",
                table: "AuditLogDetails");

            migrationBuilder.AlterColumn<string>(
                name: "ChangedKeyValues",
                table: "AuditLogs",
                type: "nvarchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OldValue",
                table: "AuditLogDetails",
                type: "nvarchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NewValue",
                table: "AuditLogDetails",
                type: "nvarchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(4000)",
                oldMaxLength: 4000,
                oldNullable: true);

            migrationBuilder.AddCheckConstraint(
                name: "CK_AuditLogs_ChangedKeyValues_CHARSET",
                table: "AuditLogs",
                sql: "[ChangedKeyValues] IS NULL OR (PATINDEX(N'%[^-A-Za-z0-9 .,''?]%', [ChangedKeyValues] COLLATE Latin1_General_BIN2) = 0)");

            migrationBuilder.AddCheckConstraint(
                name: "CK_AuditLogDetails_NewValue_CHARSET",
                table: "AuditLogDetails",
                sql: "[NewValue] IS NULL OR (PATINDEX(N'%[^-A-Za-z0-9 .,''?]%', [NewValue] COLLATE Latin1_General_BIN2) = 0)");

            migrationBuilder.AddCheckConstraint(
                name: "CK_AuditLogDetails_OldValue_CHARSET",
                table: "AuditLogDetails",
                sql: "[OldValue] IS NULL OR (PATINDEX(N'%[^-A-Za-z0-9 .,''?]%', [OldValue] COLLATE Latin1_General_BIN2) = 0)");
        }
    }
}
