﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class dd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentDetails_EmployeeDetails_EmployeeEmpId",
                table: "DepartmentDetails");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentDetails_EmployeeEmpId",
                table: "DepartmentDetails");

            migrationBuilder.DropColumn(
                name: "EmpId",
                table: "DepartmentDetails");

            migrationBuilder.DropColumn(
                name: "EmployeeEmpId",
                table: "DepartmentDetails");

            migrationBuilder.AddColumn<long>(
                name: "DepartmentId",
                table: "EmployeeDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "EmployeeDetails");

            migrationBuilder.AddColumn<long>(
                name: "EmpId",
                table: "DepartmentDetails",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "EmployeeEmpId",
                table: "DepartmentDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentDetails_EmployeeEmpId",
                table: "DepartmentDetails",
                column: "EmployeeEmpId");

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentDetails_EmployeeDetails_EmployeeEmpId",
                table: "DepartmentDetails",
                column: "EmployeeEmpId",
                principalTable: "EmployeeDetails",
                principalColumn: "EmpId");
        }
    }
}
