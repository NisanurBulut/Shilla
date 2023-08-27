using MagicCity_ShillaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicCity_ShillaAPI.Data
{
    public class ShillaDbContext:DbContext
    {
        public ShillaDbContext(DbContextOptions<ShillaDbContext> options):base(options)
        {
            
        }
        public DbSet<Shilla> Shillas { get; set; }
    }
}
