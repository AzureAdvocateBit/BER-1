﻿// <auto-generated />
using BerService.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BerService.Controllers.DAL.Migrations
{
   [DbContext(typeof(RecordContext))]
    [Migration("20190330144133_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ber.DAL.Models.Record", b =>
                {
                    b.Property<string>("ApplicationName");

                    b.Property<string>("DataType");

                    b.Property<string>("Version");

                    b.Property<DateTime?>("DateCreated");

                    b.Property<DateTime?>("DateModified");

                    b.Property<string>("Value");

                    b.HasKey("ApplicationName", "DataType", "Version");

                    b.ToTable("Records");
                });
#pragma warning restore 612, 618
        }
    }
}