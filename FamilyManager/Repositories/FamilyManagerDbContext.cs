using FamilyManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FamilyManager.Repositories
{
    public class FamilyManagerDbContext : DbContext
    {
        public FamilyManagerDbContext()
        {
            this.Users = this.Set<User>();
            this.Families = this.Set<Family>();
            this.Events = this.Set<Event>();
            this.Calendars = this.Set<Calendar>();
            this.ToDoLists = this.Set<ToDoList>();
            this.Tasks = this.Set<Entities.Task>();
            this.CalendarToUsers = this.Set<CalendarToUser>();
            this.CalendarToFamilies = this.Set<CalendarToFamily>();
            this.UserToToDoLists = this.Set<UserToToDoList>();
            this.UserToFamilies = this.Set<UserToFamily>();
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

            builder.Entity<CalendarToUser>()
                .HasOne(sc => sc.User)
                .WithMany(u => u.CalendarToUsers)
                .HasForeignKey(sc => sc.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull); 

            builder.Entity<CalendarToUser>()
                .HasOne(sc => sc.Calendar)
                .WithMany(c => c.CalendarToUsers)
                .HasForeignKey(sc => sc.CalendarId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder.Entity<UserToToDoList>()
                .HasOne(sc => sc.User)
                .WithMany(u => u.UserToToDoLists)
                .HasForeignKey(sc => sc.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<UserToToDoList>()
                .HasOne(sc => sc.ToDoList)
                .WithMany(c => c.UserToToDoLists)
                .HasForeignKey(sc => sc.ToDoListId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            builder.Entity<Entities.Task>()
                .HasOne(t => t.Owner)
                .WithMany()
                .HasForeignKey(t => t.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Entities.Task>()
                .HasOne(t => t.Assignee)
                .WithMany()
                .HasForeignKey(t => t.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict); 
          
            builder.Entity<Entities.Task>()
                .HasOne(t => t.ToDoList)
                .WithMany(tdl => tdl.Tasks)
                .HasForeignKey(t => t.ToDoListId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Family> Families { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<CalendarToUser> CalendarToUsers { get; set; }
        public DbSet<CalendarToFamily> CalendarToFamilies { get; set; }
        public DbSet<UserToToDoList> UserToToDoLists { get; set; }
        public DbSet<UserToFamily> UserToFamilies { get; set; }
    }
}
