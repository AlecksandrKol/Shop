﻿using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) { }

        public DbSet<Item> Item { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<ShopCartItem> ShopCartItem { get; set; }

    }
}
