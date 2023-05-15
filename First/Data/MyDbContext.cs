using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using First.Models;


namespace First.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {

        }
        public DbSet<Acount> Acounts { get; set; }

    }
}


