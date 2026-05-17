using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw4_s30734.Models;

namespace PJATK_APBD_Cw4_s30734.Infrastructre;

public class DatabaseContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<PCs> PCs { get; set; }
    public DbSet<Components> Components { get; set; }
    public DbSet<PCComponents> PCComponents { get; set; }
    public DbSet<ComponentManufacturers> ComponentManufacturers { get; set; }
    public DbSet<ComponentTypes> ComponentTypes { get; set; }
}