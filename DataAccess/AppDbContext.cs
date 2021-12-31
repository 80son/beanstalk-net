using System;
using System.Collections.Generic;
using System.Xml.Linq;
using beanstalk_net.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace beanstalk_net.DataAccess
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        
        public virtual DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var now = DateTime.UtcNow;

            var notes = new List<Note>()
            {
                new Note
                {
                    Id = 1,
                    Content = "Finish YouTube video",
                    UpdatedOn = now,
                    CreatedOn = now
                },
                new Note
                {
                    Id = 2,
                    Content = "Go to the gym",
                    UpdatedOn = now,
                    CreatedOn = now
                },
                new Note
                {
                    Id = 3,
                    Content = "Go to the grocery market",
                    UpdatedOn = now,
                    CreatedOn = now
                }
            };

            modelBuilder.Entity<Note>().HasData(notes);
        }
    }
}