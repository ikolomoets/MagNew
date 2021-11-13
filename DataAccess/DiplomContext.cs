using Diplom.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

public class DiplomContext : DbContext
{
    public DiplomContext(DbContextOptions<DiplomContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HWaveESourceItem>()
            .HasOne(p => p.HWaveEItem)
            .WithMany(b => b.HWaveESourceItems);

        modelBuilder.Entity<HWaveWSourceItem>()
            .HasOne(p => p.HWaveWItem)
            .WithMany(b => b.HWaveWSourceItems);



        modelBuilder.Entity<LWaveErSourceItem>()
            .HasOne(p => p.LWaveErItem)
            .WithMany(b => b.LWaveErSourceItems);

        modelBuilder.Entity<LWavePSourceItem>()
            .HasOne(p => p.LWavePItem)
            .WithMany(b => b.LWavePSourceItems);

        modelBuilder.Entity<LWaveHrSourceItem>()
            .HasOne(p => p.LWaveHrItem)
            .WithMany(b => b.LWaveHrSourceItems);

        modelBuilder.Entity<LWavemSourceItem>()
            .HasOne(p => p.LWavemItem)
            .WithMany(b => b.LWavemSourceItems);
    }

    public DbSet<HWaveEoneItem> HWaveEoneItems { get; set; }
    public DbSet<HWaveWoneItem> HWaveWoneItems { get; set; }



    public DbSet<HWaveEItem> HWaveEItem { get; set; }
    public DbSet<HWaveESourceItem> HWaveESourceItem { get; set; }


    public DbSet<HWaveWItem> HWaveWItem { get; set; }
    public DbSet<HWaveWSourceItem> HWaveWSourceItem { get; set; }



    public DbSet<LWaveErItem> LWaveErItem { get; set; }
    public DbSet<LWaveErSourceItem> LWaveErSourceItem { get; set; }

    public DbSet<LWavePItem> LWavePItem { get; set; }
    public DbSet<LWavePSourceItem> LWavePSourceItem { get; set; }

    public DbSet<LWaveHrItem> LWaveHrItem { get; set; }
    public DbSet<LWaveHrSourceItem> LWaveHrSourceItem { get; set; }

    public DbSet<LWavemItem> LWavemItem { get; set; }
    public DbSet<LWavemSourceItem> LWavemSourceItem { get; set; }
}