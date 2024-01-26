﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SDProject.Data;

#nullable disable

namespace SDProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230521130720_finalrelease3")]
    partial class finalrelease3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SDProject.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("SDProject.Models.Case", b =>
                {
                    b.Property<int>("CaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaseId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CaseGender")
                        .HasColumnType("int");

                    b.Property<string>("Dieseases")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilySize")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InspectorId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MonthlyEarnings")
                        .HasColumnType("real");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CaseId");

                    b.HasIndex("InspectorId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("SDProject.Models.CaseInspector", b =>
                {
                    b.Property<int>("InspectorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InspectorId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.HasKey("InspectorId");

                    b.ToTable("Inspectors");
                });

            modelBuilder.Entity("SDProject.Models.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("SDProject.Models.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"));

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<string>("FinalConclusion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IfDataValid")
                        .HasColumnType("bit");

                    b.Property<int>("TypeOfCase")
                        .HasColumnType("int");

                    b.HasKey("ReportId");

                    b.HasIndex("CaseId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("SDProject.Models.Case", b =>
                {
                    b.HasOne("SDProject.Models.CaseInspector", "Inspector")
                        .WithMany("Cases")
                        .HasForeignKey("InspectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Inspector");
                });

            modelBuilder.Entity("SDProject.Models.Report", b =>
                {
                    b.HasOne("SDProject.Models.Case", "MyCase")
                        .WithMany("MyReports")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MyCase");
                });

            modelBuilder.Entity("SDProject.Models.Case", b =>
                {
                    b.Navigation("MyReports");
                });

            modelBuilder.Entity("SDProject.Models.CaseInspector", b =>
                {
                    b.Navigation("Cases");
                });
#pragma warning restore 612, 618
        }
    }
}
