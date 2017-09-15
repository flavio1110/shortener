using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Shortener.Web.Data;

namespace Shortener.Web.Migrations
{
    [DbContext(typeof(DbUrlContext))]
    [Migration("20170915194852_IncreaseIncrement")]
    public class IncreaseIncrement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE longurl AUTO_INCREMENT = 1000;");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("ALTER TABLE longurl AUTO_INCREMENT = 1;");
        }
    }
}
