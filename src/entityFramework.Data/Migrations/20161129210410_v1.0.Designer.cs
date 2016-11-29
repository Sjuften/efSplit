using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using entityFramework.Data.Databases;
using entityFramework.Data.Entities;

namespace entityFramework.Data.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20161129210410_v1.0")]
    partial class v10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("entityFramework.Data.Entities.Ninja", b =>
                {
                    b.Property<int>("NinjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("NinjaType");

                    b.HasKey("NinjaId");

                    b.ToTable("Ninja");
                });
        }
    }
}
