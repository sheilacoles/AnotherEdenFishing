using Microsoft.EntityFrameworkCore;
using Sheila.AnotherEdenFishing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheila.AnotherEdenFishing
{
    public class AnotherEdenFishingDbContext:DbContext
    {
        public DbSet<Fish> Fish { get; set; }
        public DbSet<Pond> Pond { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<FishBait> FishBait { get; set; }
        public DbSet<FishBaitQuality> FishBaitQuality { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=.\\SQLExpress;Database=AnotherEdenFishing;Trusted_Connection=True;");
    }
}
