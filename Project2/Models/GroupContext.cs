using System;
using Microsoft.EntityFrameworkCore;
namespace Project2.Models


{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options) : base(options)
        {
        }
        public DbSet<Group> Appts { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Group>().HasData(
                    new Group
                    {
                        GroupId = 1,
                        GroupName = "Sam's Group",
                        GroupSize = 10,
                        Email = "test@gmail.com",
                        Phone = "8013628071",

                    }

            );

        }

    }
}



