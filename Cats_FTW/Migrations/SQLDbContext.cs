using Cats_FTW.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Cats_FTW.Migrations
{
    public class SQLDbContext: DbContext
    {
        public DbSet<CatFact> CatFacts { get; set; }
        public DbSet<CatImage> CatImages { get; set; }

        // If you wish to target a different database and/or database provider, modify the 'EntityModel' 
        // connection string in the application configuration file.
        public SQLDbContext()
            : base("name=SQLDbContext")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        public static SQLDbContext Create()
        {
            return new SQLDbContext();
        }

    }
}