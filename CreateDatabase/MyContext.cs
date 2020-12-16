using CreateDatabase.DAL.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateDatabase.DAL
{
    public class MyContext : DbContext
    {
        public DbSet<Tag> tags { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<PostTagMap> postMapTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=95.214.10.36;Port=5432;Database=denysdb;Username=denys;Password=qwerty1*");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PostTagMap>().HasNoKey();
        }
    }
}
