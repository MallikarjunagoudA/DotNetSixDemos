using E2E.CURD.Operations.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace E2E.CURD.Operations.Data
{
    public class WalksdbContext: DbContext
    {

        public WalksdbContext(DbContextOptions<WalksdbContext> options): base(options)
        {

        }

        DbSet<Region> Regions { get; set; }
        DbSet<WalkDifficulty> WalkDifficulties { get; set; }
        DbSet<Walk> walks { get; set; }

    }
}
