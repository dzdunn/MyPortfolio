using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyPortfolio.DAL
{
    public class MyPortfolioContext : DbContext
    {
        public MyPortfolioContext() : base("MyPortfolioContext")
        {
            Database.SetInitializer<MyPortfolioContext>(new MyPortfolioInitialiser());
        }

        public DbSet<Image> Images { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<ProgrammingProject> ProgrammingProjects { get; set; }
        public DbSet<DroneProject> DroneProjects { get; set; }
        public DbSet<ThreeDPrintingProject> ThreeDPrintingProjects { get; set; }

    }
}