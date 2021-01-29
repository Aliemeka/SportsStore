﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsStore.Domain.Entities;

namespace SportsStore.Domain.Data
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}