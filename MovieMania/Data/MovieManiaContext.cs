using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieMania.Data
{
    public class MovieManiaContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public MovieManiaContext() : base("name=MovieManiaContext")
        {
            Database.SetInitializer<MovieManiaContext>(new DatabaseInitializer());
        }

        public System.Data.Entity.DbSet<MovieMania.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<MovieMania.Models.Serie> Series { get; set; }

        public System.Data.Entity.DbSet<MovieMania.Models.Plan> Plans { get; set; }

        public System.Data.Entity.DbSet<MovieMania.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<MovieMania.Models.Invoice> Invoices { get; set; }

        public System.Data.Entity.DbSet<MovieMania.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MovieMania.Models.Episode> Episodes { get; set; }
    }
}
