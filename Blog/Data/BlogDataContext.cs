﻿using Blog.Models;
using Blog_EntityFrameworkCore.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class BlogDataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        //public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=LAPTOP-563RGJKO\\SQLEXPRESS;Initial Catalog=Blog; Integrated Security=True");

        // Configuração dos Mapeamentos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new  PostMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
