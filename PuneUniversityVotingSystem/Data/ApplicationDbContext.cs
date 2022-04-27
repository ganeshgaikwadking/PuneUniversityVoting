using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PuneUniversityVotingSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PuneUniversityVotingSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Users> User { get; set; }
        public DbSet<Questions> Questions { get; set; }

        public DbSet<Options> options { get; set; }
    }
}
