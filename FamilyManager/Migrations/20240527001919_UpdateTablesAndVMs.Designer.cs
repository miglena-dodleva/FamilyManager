﻿// <auto-generated />
using System;
using FamilyManager.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyManager.Migrations
{
    [DbContext(typeof(FamilyManagerDbContext))]
    [Migration("20240527001919_UpdateTablesAndVMs")]
    partial class UpdateTablesAndVMs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FamilyManager.Entities.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("FamilyManager.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsAFullDayEvent")
                        .HasColumnType("bit");

                    b.Property<int>("IsRepeatEvent")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("ThemeColor")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FamilyManager.Entities.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("FamilyManager.Entities.SharedCalendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("UserId");

                    b.ToTable("SharedCalendars");
                });

            modelBuilder.Entity("FamilyManager.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssigneeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToDoListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ToDoListId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FamilyManager.Entities.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("FamilyManager.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "miglenadodleva@gmail.com",
                            FirstName = "Miglena",
                            LastName = "Dodleva",
                            Password = "megipass",
                            PhoneNumber = "088-406-8870",
                            Username = "megi"
                        });
                });

            modelBuilder.Entity("FamilyManager.Entities.Calendar", b =>
                {
                    b.HasOne("FamilyManager.Entities.User", "Owner")
                        .WithMany("Calendars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FamilyManager.Entities.Event", b =>
                {
                    b.HasOne("FamilyManager.Entities.Calendar", "Calendar")
                        .WithMany("Events")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");
                });

            modelBuilder.Entity("FamilyManager.Entities.SharedCalendar", b =>
                {
                    b.HasOne("FamilyManager.Entities.Calendar", "Calendar")
                        .WithMany("SharedCalendars")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("FamilyManager.Entities.User", "User")
                        .WithMany("SharedCalendars")
                        .HasForeignKey("UserId")
                        .IsRequired();

                    b.Navigation("Calendar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FamilyManager.Entities.Task", b =>
                {
                    b.HasOne("FamilyManager.Entities.User", "Assignee")
                        .WithMany("AssignedTasks")
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FamilyManager.Entities.User", "Owner")
                        .WithMany("OwnedTasks")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FamilyManager.Entities.ToDoList", "ToDoList")
                        .WithMany("Tasks")
                        .HasForeignKey("ToDoListId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Owner");

                    b.Navigation("ToDoList");
                });

            modelBuilder.Entity("FamilyManager.Entities.ToDoList", b =>
                {
                    b.HasOne("FamilyManager.Entities.User", "Owner")
                        .WithMany("ToDoLists")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("FamilyManager.Entities.User", b =>
                {
                    b.HasOne("FamilyManager.Entities.Family", "Family")
                        .WithMany("Users")
                        .HasForeignKey("FamilyId");

                    b.Navigation("Family");
                });

            modelBuilder.Entity("FamilyManager.Entities.Calendar", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("SharedCalendars");
                });

            modelBuilder.Entity("FamilyManager.Entities.Family", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("FamilyManager.Entities.ToDoList", b =>
                {
                    b.Navigation("Tasks");
                });

            modelBuilder.Entity("FamilyManager.Entities.User", b =>
                {
                    b.Navigation("AssignedTasks");

                    b.Navigation("Calendars");

                    b.Navigation("OwnedTasks");

                    b.Navigation("SharedCalendars");

                    b.Navigation("ToDoLists");
                });
#pragma warning restore 612, 618
        }
    }
}
