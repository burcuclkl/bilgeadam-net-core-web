using Microsoft.EntityFrameworkCore;
using Restaurant.Areas.Admin.Models.Entities;
using Restaurant.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Models.ORM.Context
{
    public class ProjectContext :DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
        {

        }

        public DbSet<RestaurantBase> restaurantBases { get; set; }

        public DbSet<RestaurantDetail> restaurantDetails { get; set; }
    }
}
