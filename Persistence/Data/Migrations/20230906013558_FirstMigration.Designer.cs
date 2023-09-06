﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(ApiIncidenciasIContext))]
    [Migration("20230906013558_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Area", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("area", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("DocTypeId")
                        .HasColumnType("int");

                    b.Property<int>("IdContactCategoryFk")
                        .HasColumnType("int");

                    b.Property<int>("IdContactTypeFk")
                        .HasColumnType("int");

                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DocTypeId");

                    b.HasIndex("IdContactCategoryFk");

                    b.HasIndex("IdContactTypeFk");

                    b.HasIndex("IdUserFk");

                    b.ToTable("contact", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ContactCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("contact_category", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ContactType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("contact_type", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.DocType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("doc_type", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Incidence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdAreaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPlaceFk")
                        .HasColumnType("int");

                    b.Property<int>("IdStateFk")
                        .HasColumnType("int");

                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdAreaFk");

                    b.HasIndex("IdPlaceFk");

                    b.HasIndex("IdStateFk");

                    b.HasIndex("IdUserFk");

                    b.ToTable("incidence", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.IncidenceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdIncidenceLevelFk")
                        .HasColumnType("int");

                    b.Property<int>("IdIncidenceTypeFk")
                        .HasColumnType("int");

                    b.Property<int>("IdStateFk")
                        .HasColumnType("int");

                    b.Property<int>("IdWorkToolFk")
                        .HasColumnType("int");

                    b.Property<int?>("IncidenceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdIncidenceLevelFk");

                    b.HasIndex("IdIncidenceTypeFk");

                    b.HasIndex("IdStateFk");

                    b.HasIndex("IdWorkToolFk");

                    b.HasIndex("IncidenceId");

                    b.ToTable("incidence_detail", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.IncidenceLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("incidence_level", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.IncidenceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("incidence_type", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("IdAreaFk")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdAreaFk");

                    b.ToTable("place", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("state", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<int>("IdDocTypeFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRoleFk")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDocTypeFk");

                    b.HasIndex("IdRoleFk");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UserArea", b =>
                {
                    b.Property<int>("IdUserFk")
                        .HasColumnType("int");

                    b.Property<int>("IdAreaFk")
                        .HasColumnType("int");

                    b.Property<int?>("AreaId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("IdUserFk", "IdAreaFk");

                    b.HasIndex("AreaId");

                    b.HasIndex("UserId");

                    b.ToTable("UserArea");
                });

            modelBuilder.Entity("Domain.Entities.WorkTool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("work_tool", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Contact", b =>
                {
                    b.HasOne("Domain.Entities.DocType", null)
                        .WithMany("Contacts")
                        .HasForeignKey("DocTypeId");

                    b.HasOne("Domain.Entities.ContactCategory", "ContactCategory")
                        .WithMany("Contacts")
                        .HasForeignKey("IdContactCategoryFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ContactType", "ContactType")
                        .WithMany("Contacts")
                        .HasForeignKey("IdContactTypeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ContactCategory");

                    b.Navigation("ContactType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Incidence", b =>
                {
                    b.HasOne("Domain.Entities.Area", "Area")
                        .WithMany("Incidences")
                        .HasForeignKey("IdAreaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Place", "Place")
                        .WithMany("Incidences")
                        .HasForeignKey("IdPlaceFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.State", "State")
                        .WithMany("Incidences")
                        .HasForeignKey("IdStateFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("Incidences")
                        .HasForeignKey("IdUserFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");

                    b.Navigation("Place");

                    b.Navigation("State");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.IncidenceDetail", b =>
                {
                    b.HasOne("Domain.Entities.IncidenceLevel", "IncidenceLevel")
                        .WithMany("IncidenceDetails")
                        .HasForeignKey("IdIncidenceLevelFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.IncidenceType", "IncidenceType")
                        .WithMany("IncidenceDetails")
                        .HasForeignKey("IdIncidenceTypeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.State", "State")
                        .WithMany("IncidenceDetails")
                        .HasForeignKey("IdStateFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.WorkTool", "WorkTool")
                        .WithMany("IncidenceDetails")
                        .HasForeignKey("IdWorkToolFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Incidence", null)
                        .WithMany("IncidenceDetails")
                        .HasForeignKey("IncidenceId");

                    b.Navigation("IncidenceLevel");

                    b.Navigation("IncidenceType");

                    b.Navigation("State");

                    b.Navigation("WorkTool");
                });

            modelBuilder.Entity("Domain.Entities.Place", b =>
                {
                    b.HasOne("Domain.Entities.Area", "Area")
                        .WithMany("Places")
                        .HasForeignKey("IdAreaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.DocType", "DocType")
                        .WithMany("Users")
                        .HasForeignKey("IdDocTypeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("IdRoleFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocType");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Entities.UserArea", b =>
                {
                    b.HasOne("Domain.Entities.Area", "Area")
                        .WithMany("UserAreas")
                        .HasForeignKey("AreaId");

                    b.HasOne("Domain.Entities.User", "User")
                        .WithMany("UserAreas")
                        .HasForeignKey("UserId");

                    b.Navigation("Area");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Area", b =>
                {
                    b.Navigation("Incidences");

                    b.Navigation("Places");

                    b.Navigation("UserAreas");
                });

            modelBuilder.Entity("Domain.Entities.ContactCategory", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Domain.Entities.ContactType", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("Domain.Entities.DocType", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.Incidence", b =>
                {
                    b.Navigation("IncidenceDetails");
                });

            modelBuilder.Entity("Domain.Entities.IncidenceLevel", b =>
                {
                    b.Navigation("IncidenceDetails");
                });

            modelBuilder.Entity("Domain.Entities.IncidenceType", b =>
                {
                    b.Navigation("IncidenceDetails");
                });

            modelBuilder.Entity("Domain.Entities.Place", b =>
                {
                    b.Navigation("Incidences");
                });

            modelBuilder.Entity("Domain.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.State", b =>
                {
                    b.Navigation("IncidenceDetails");

                    b.Navigation("Incidences");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Incidences");

                    b.Navigation("UserAreas");
                });

            modelBuilder.Entity("Domain.Entities.WorkTool", b =>
                {
                    b.Navigation("IncidenceDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
