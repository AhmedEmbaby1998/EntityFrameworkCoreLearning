﻿// <auto-generated />
using System;
using EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Samor.Migrations
{
    [DbContext(typeof(SamoraiContext))]
    [Migration("20200415063544_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.2.20159.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFramework.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClanName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("EntityFramework.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SamoraiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SamoraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("EntityFramework.Samorai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClanId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClanId");

                    b.ToTable("Samorais");
                });

            modelBuilder.Entity("Samor.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Battle");
                });

            modelBuilder.Entity("Samor.SamoraiBattle", b =>
                {
                    b.Property<int>("BattleId")
                        .HasColumnType("int");

                    b.Property<int>("SamoraiId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("BattleId", "SamoraiId");

                    b.HasIndex("SamoraiId");

                    b.ToTable("SamoraiBattle");
                });

            modelBuilder.Entity("EntityFramework.Quote", b =>
                {
                    b.HasOne("EntityFramework.Samorai", "Samorai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamoraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityFramework.Samorai", b =>
                {
                    b.HasOne("EntityFramework.Clan", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId");
                });

            modelBuilder.Entity("Samor.SamoraiBattle", b =>
                {
                    b.HasOne("Samor.Battle", "Battle")
                        .WithMany()
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityFramework.Samorai", "Samorai")
                        .WithMany("BattlesFought")
                        .HasForeignKey("SamoraiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
