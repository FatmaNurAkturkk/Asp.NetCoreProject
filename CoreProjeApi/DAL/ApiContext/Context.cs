﻿using CoreProjeApi.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreProjeApi.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-C2KA1FFQ\\SQLEXPRESS;database=CoreProjeDb2;integrated security=true;");
        }
        public DbSet<Category> Categories { get; set; }

    }
}
