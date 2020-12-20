using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using White_Elephant.Models;
namespace White_Elephant.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Gift> Gifts { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Ornament> Ornaments { get; set; }
        public DbSet<GiftWrap> GiftWraps { get; set; }
    }
}
