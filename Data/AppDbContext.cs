using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;
 
using Microsoft.EntityFrameworkCore.Design;
using SQLitePCL;

namespace API.Data
{
    
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        // Initialize SQLite provider before creating the context
        
        
        public DbSet<AppUser> Users { get; set; }

    }
}