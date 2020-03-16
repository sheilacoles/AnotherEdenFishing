﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sheila.AnotherEdenFishing;

namespace Sheila.AnotherEdenFishing.Migrations
{
    [DbContext(typeof(AnotherEdenFishingDbContext))]
    [Migration("20200201115125_AddFishBait")]
    partial class AddFishBait
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.Fish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("PondId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("PondId");

                    b.ToTable("Fish");
                });

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.FishBait", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QualityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QualityId");

                    b.ToTable("FishBait");
                });

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.FishBaitQuality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FishBaitQuality");
                });

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.Pond", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pond");
                });

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.Fish", b =>
                {
                    b.HasOne("Sheila.AnotherEdenFishing.Models.Player", null)
                        .WithMany("Fish")
                        .HasForeignKey("PlayerId");

                    b.HasOne("Sheila.AnotherEdenFishing.Models.Pond", null)
                        .WithMany("Fish")
                        .HasForeignKey("PondId");
                });

            modelBuilder.Entity("Sheila.AnotherEdenFishing.Models.FishBait", b =>
                {
                    b.HasOne("Sheila.AnotherEdenFishing.Models.FishBaitQuality", "Quality")
                        .WithMany()
                        .HasForeignKey("QualityId");
                });
#pragma warning restore 612, 618
        }
    }
}