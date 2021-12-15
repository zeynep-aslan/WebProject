using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieWebsite.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Film { get; set; }

        public DbSet<Dil> Dil { get; set; }

        public DbSet<Kategori> Kategori { get; set; }


    }
}
