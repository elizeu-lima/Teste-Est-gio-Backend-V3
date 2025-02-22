using EquipmentTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace EquipmentTracking.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Equipment> Equipments { get; set; }
    public DbSet<EquipmentModel> EquipmentModels { get; set; }
    public DbSet<EquipmentState> EquipmentStates { get; set; }
    public DbSet<EquipmentStateHistory> EquipmentStateHistories { get; set; }
    public DbSet<EquipmentPositionHistory> EquipmentPositionHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
