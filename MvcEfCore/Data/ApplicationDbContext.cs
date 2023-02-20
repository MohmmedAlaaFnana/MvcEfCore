using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcEfCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvcEfCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Team> teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
