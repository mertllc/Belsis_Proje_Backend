using deneme0.Models;
using Microsoft.EntityFrameworkCore;
namespace proje_deneme.Controllers
{
    public class ParcelDbContext : DbContext
    {
        public ParcelDbContext(DbContextOptions<ParcelDbContext> options) : base(options)
        {

        }
        public DbSet<Parcel> Parcels { get; set; }

    }
}