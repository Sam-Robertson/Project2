using System;
using Microsoft.EntityFrameworkCore;
namespace Project2.Models


{
    public class ApptContext : DbContext
    {
        public ApptContext(DbContextOptions<ApptContext> options) : base(options)
        {
        }
        public DbSet<Appointment> Appts { get; set; }

        // This isn't working and idk why, but I also haven't looked at it very seriously

        //mb.Entity<Appointment>().HasData(
        //        new Appointment
        //        {
        //            ApptId = 1,
        //            groupName = "Sam's Group",
        //            groupSize = 10,
        //            Email = "test@gmail.com",
        //            Phone = "8013628071",
         
        //        }
            
        //);
      
    }
}



