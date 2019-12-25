using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using CandidateManagementEF.Models;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.FileExtensions;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CandidateManagementEF
{
    public class CMDbContext : DbContext
    {

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillUser> SkillUser { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json");
            var config = builder.Build();
            //var providers = config.Providers;
            var connectionString = config.GetConnectionString("ManagementDBConnectionString");
            var providers = config.Providers;
            

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =.;Initial Catalog= CandidateManagementDB;Integrated Security=true");
            }
        }


    }
}
