﻿using FamilyManager.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace FamilyManager.Repositories
{
    public class FamilyManagerDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<SharedCalendar> SharedCalendars { get; set; }
        
        public FamilyManagerDbContext()
        {
            this.Users = this.Set<User>();
            this.Families = this.Set<Family>();
            this.Events = this.Set<Event>();
            this.Calendars = this.Set<Calendar>();
            this.ToDoLists = this.Set<ToDoList>();
            this.Tasks = this.Set<Entities.Task>();
            this.SharedCalendars = this.Set<SharedCalendar>();
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=.;Database=FamilyManagerDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true")
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User()
            {
                Id = 1,
                Username = "megi",
                Password = "megipass",
                FirstName = "Miglena",
                LastName = "Dodleva",
                Email = "miglenadodleva@gmail.com",
                PhoneNumber = "088-406-8870",
                FamilyId = null
            });

            builder.Entity<User>()
                .Property(u => u.FamilyId)
                .IsRequired(false); // FamilyId не е задължително

            builder.Entity<SharedCalendar>()
                .HasOne(sc => sc.User)
                .WithMany(u => u.SharedCalendars)
                .HasForeignKey(sc => sc.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull); 

            builder.Entity<SharedCalendar>()
                .HasOne(sc => sc.Calendar)
                .WithMany(c => c.SharedCalendars)
                .HasForeignKey(sc => sc.CalendarId)
                .OnDelete(DeleteBehavior.ClientNoAction);  

            builder.Entity<Entities.Task>()
                .HasOne(t => t.Owner)
                .WithMany(u => u.OwnedTasks)
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Entities.Task>()
                .HasOne(t => t.Assignee)
                .WithMany(u => u.AssignedTasks)
                .HasForeignKey(t => t.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<Entities.Task>()
                .HasOne(t => t.ToDoList)
                .WithMany(tdl => tdl.Tasks)
                .HasForeignKey(t => t.ToDoListId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
