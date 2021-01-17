﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieRater;

namespace MovieRater.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MovieRater.Models.Film", b =>
                {
                    b.Property<int>("episode_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("avg");

                    b.Property<DateTime>("created");

                    b.Property<string>("director");

                    b.Property<DateTime>("edited");

                    b.Property<int>("numberOfVotes");

                    b.Property<string>("opening_crawl");

                    b.Property<string>("producer");

                    b.Property<string>("release_date");

                    b.Property<string>("title");

                    b.Property<string>("url");

                    b.HasKey("episode_id");

                    b.ToTable("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
