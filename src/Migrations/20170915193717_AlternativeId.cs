using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Shortener.Web.Data;

namespace Shortener.Web.Migrations
{
    [DbContext(typeof(DbUrlContext))]
    [Migration("20170915193717_AlternativeId")]
    public class AlternativeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("AltId", "LongUrl", nullable:false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("AltId", "LongUrl");
        }
    }
}
