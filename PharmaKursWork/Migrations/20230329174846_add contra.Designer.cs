﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PharmaKursWork.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230329174846_add contra")]
    partial class addcontra
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PharmaKursWork.Models.Challenge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("ChallegesStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScientistId")
                        .HasColumnType("int");

                    b.Property<int>("TechStaffId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedsId");

                    b.HasIndex("ScientistId");

                    b.HasIndex("TechStaffId");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Challenger", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<string>("Contraindications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChallengeId");

                    b.ToTable("Challengers");
                });

            modelBuilder.Entity("PharmaKursWork.Models.CommodityGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CommodityGroups");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Laboratory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Laboratories");
                });

            modelBuilder.Entity("PharmaKursWork.Models.LaboratoryEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LabratoryId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LabratoryId");

                    b.ToTable("LaboratoryEmployees");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Med", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CommodityGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Contraindications")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Expenses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("LabratoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartExploring")
                        .HasColumnType("datetime2");

                    b.Property<int>("UnitMeasureId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommodityGroupId");

                    b.HasIndex("LabratoryId");

                    b.HasIndex("UnitMeasureId");

                    b.ToTable("Meds");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Scientist", b =>
                {
                    b.Property<int>("LaboratoryEmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("DirectionDevelopment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsibleForDevice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LaboratoryEmployeeId");

                    b.ToTable("Scientists");
                });

            modelBuilder.Entity("PharmaKursWork.Models.TechStaff", b =>
                {
                    b.Property<int>("LaboratoryEmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("HasYourInstruments")
                        .HasColumnType("bit");

                    b.Property<string>("MaintainsDevice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LaboratoryEmployeeId");

                    b.ToTable("TechStaffs");
                });

            modelBuilder.Entity("PharmaKursWork.Models.UnitMeasure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnitMeasures");
                });

            modelBuilder.Entity("PharmaKursWork.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("authenticationKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Challenge", b =>
                {
                    b.HasOne("PharmaKursWork.Models.Med", "Med")
                        .WithMany()
                        .HasForeignKey("MedsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaKursWork.Models.Scientist", "Scientist")
                        .WithMany()
                        .HasForeignKey("ScientistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaKursWork.Models.TechStaff", "TechStaff")
                        .WithMany()
                        .HasForeignKey("TechStaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Med");

                    b.Navigation("Scientist");

                    b.Navigation("TechStaff");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Challenger", b =>
                {
                    b.HasOne("PharmaKursWork.Models.Challenge", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId");

                    b.HasOne("PharmaKursWork.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PharmaKursWork.Models.LaboratoryEmployee", b =>
                {
                    b.HasOne("PharmaKursWork.Models.Laboratory", "Laboratory")
                        .WithMany()
                        .HasForeignKey("LabratoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratory");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Med", b =>
                {
                    b.HasOne("PharmaKursWork.Models.CommodityGroup", "CommodityGroup")
                        .WithMany()
                        .HasForeignKey("CommodityGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaKursWork.Models.Laboratory", "Laboratory")
                        .WithMany()
                        .HasForeignKey("LabratoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PharmaKursWork.Models.UnitMeasure", "UnitMeasure")
                        .WithMany()
                        .HasForeignKey("UnitMeasureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommodityGroup");

                    b.Navigation("Laboratory");

                    b.Navigation("UnitMeasure");
                });

            modelBuilder.Entity("PharmaKursWork.Models.Scientist", b =>
                {
                    b.HasOne("PharmaKursWork.Models.LaboratoryEmployee", "laboratoryEmployee")
                        .WithMany()
                        .HasForeignKey("LaboratoryEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("laboratoryEmployee");
                });

            modelBuilder.Entity("PharmaKursWork.Models.TechStaff", b =>
                {
                    b.HasOne("PharmaKursWork.Models.LaboratoryEmployee", "laboratoryEmployee")
                        .WithMany()
                        .HasForeignKey("LaboratoryEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("laboratoryEmployee");
                });
#pragma warning restore 612, 618
        }
    }
}
