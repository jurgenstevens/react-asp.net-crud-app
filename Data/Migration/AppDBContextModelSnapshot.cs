﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetserver.Data;

#nullable disable

namespace aspnetserver.Data.Migration
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("aspnetserver.Data.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<object>("Content")
                        .IsRequired()
                        .HasMaxLength(100000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("PostId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Content = "1) Hello World!",
                            Title = "Post 1"
                        },
                        new
                        {
                            PostId = 2,
                            Content = "2) Hello World!",
                            Title = "Post 2"
                        },
                        new
                        {
                            PostId = 3,
                            Content = "3) Hello World!",
                            Title = "Post 3"
                        },
                        new
                        {
                            PostId = 4,
                            Content = "4) Hello World!",
                            Title = "Post 4"
                        },
                        new
                        {
                            PostId = 5,
                            Content = "5) Hello World!",
                            Title = "Post 5"
                        },
                        new
                        {
                            PostId = 6,
                            Content = "6) Hello World!",
                            Title = "Post 6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
