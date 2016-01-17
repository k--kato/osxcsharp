using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using StarWars.Models;

namespace StarWars.Migrations
{
    [DbContext(typeof(StarWarsContext))]
    [Migration("20160117135945_StarWarsEp7")]
    partial class StarWarsEp7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("StarWars.Model.Director", b =>
                {
                    b.Property<int>("DirectorId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Born");

                    b.Property<int>("Episode");

                    b.Property<string>("Name");

                    b.HasKey("DirectorId");
                });
        }
    }
}
