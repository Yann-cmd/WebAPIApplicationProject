using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebAPIApplicationProject.Models
{
    public class PlantFoodContext : DbContext
    {
        public PlantFoodContext(DbContextOptions<PlantFoodContext> options) : base(options) { }

        public DbSet<PlantFood> PlantFoods { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
