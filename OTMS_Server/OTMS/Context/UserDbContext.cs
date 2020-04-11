using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace OTMS.Context
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions Options):base(Options)
        {

        }
        public DbSet<User> Users { get; set; }

        public DbSet<TripDetails> TripDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { User_Id = 1, Pwd = "John", Role = "Developer" },
                new User() { User_Id = 2, Pwd = "Chris", Role = "Admin" },
                new User() { User_Id = 3, Pwd = "Mukesh", Role = "Consultant" });



            modelBuilder.Entity<TripDetails>().HasData(
               new TripDetails() { Trip_id = 1, User_Id = 1, Trip_Name = "KOllam", Source = "ERS", Destination = "QLN", Fare = 100, Duration = 5 },
               new TripDetails() { Trip_id = 2, User_Id = 2, Trip_Name = "TVM", Source = "ERS", Destination = "TVM", Fare = 100, Duration = 7 },
               new TripDetails() { Trip_id = 3, User_Id = 1, Trip_Name = "THR", Source = "ERS", Destination = "THR", Fare = 300, Duration = 5 },

               new TripDetails() { Trip_id = 4, User_Id = 3, Trip_Name = "KTY", Source = "ERS", Destination = "KTY", Fare = 100, Duration = 3 },
               new TripDetails() { Trip_id = 5, User_Id = 3, Trip_Name = "ALP", Source = "ERS", Destination = "ALP", Fare = 50, Duration = 2 }
                );
        }
        
    }
}
