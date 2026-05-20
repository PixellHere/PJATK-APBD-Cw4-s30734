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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ComponentManufacturers>().HasData([
            new ComponentManufacturers { Id = 1, Abbreviation = "INT", FullName = "Intel Corporation", FoundationDate = new DateOnly(1968, 7, 18) },
            new ComponentManufacturers { Id = 2, Abbreviation = "AMD", FullName = "Advanced Micro Devices", FoundationDate = new DateOnly(1969, 5, 1) },
            new ComponentManufacturers { Id = 3, Abbreviation = "NVDA", FullName = "Nvidia Corporation", FoundationDate = new DateOnly(1993, 4, 5) },
            new ComponentManufacturers { Id = 4, Abbreviation = "ASUS", FullName = "ASUSTeK Computer Inc.", FoundationDate = new DateOnly(1989, 4, 2) },
            new ComponentManufacturers { Id = 5, Abbreviation = "MSI", FullName = "Micro-Star International", FoundationDate = new DateOnly(1986, 8, 4) }
        ]);

        modelBuilder.Entity<ComponentTypes>().HasData([
            new ComponentTypes { Id = 1, Abbreviation = "CPU", Name = "Central Processing Unit" },
            new ComponentTypes { Id = 2, Abbreviation = "GPU", Name = "Graphics Processing Unit" },
            new ComponentTypes { Id = 3, Abbreviation = "MB", Name = "Motherboard" },
            new ComponentTypes { Id = 4, Abbreviation = "RAM", Name = "Random Access Memory" },
            new ComponentTypes { Id = 5, Abbreviation = "PSU", Name = "Power Supply Unit" }
        ]);

        modelBuilder.Entity<Components>().HasData([
            new Components { Code = "COMP-00001", Name = "Intel Core i9-13900K", Description = "High-end CPU", ComponentManufacturersId = 1, ComponentTypesId = 1 },
            new Components { Code = "COMP-00002", Name = "AMD Ryzen 9 7950X", Description = "High-end CPU", ComponentManufacturersId = 2, ComponentTypesId = 1 },
            new Components { Code = "COMP-00003", Name = "Nvidia RTX 4090", Description = "High-end GPU", ComponentManufacturersId = 3, ComponentTypesId = 2 },
            new Components { Code = "COMP-00004", Name = "ASUS ROG MAXIMUS Z790 HERO", Description = "High-end Motherboard", ComponentManufacturersId = 4, ComponentTypesId = 3 },
            new Components { Code = "COMP-00005", Name = "MSI MPG B650 CARBON", Description = "Mid-range Motherboard", ComponentManufacturersId = 5, ComponentTypesId = 3 }
        ]);

        modelBuilder.Entity<PCs>().HasData([
            new PCs { Id = 1, Name = "Gamer Pro X", Weight = 15.5f, Warranty = 24, CreatedAt = new DateTime(2024, 1, 10), Stock = 10 },
            new PCs { Id = 2, Name = "Office Workstation", Weight = 8.2f, Warranty = 12, CreatedAt = new DateTime(2024, 2, 15), Stock = 50 },
            new PCs { Id = 3, Name = "Creator Studio 9000", Weight = 18.0f, Warranty = 36, CreatedAt = new DateTime(2024, 3, 20), Stock = 5 },
            new PCs { Id = 4, Name = "Budget Gamer", Weight = 12.1f, Warranty = 24, CreatedAt = new DateTime(2024, 4, 5), Stock = 20 },
            new PCs { Id = 5, Name = "Home Media PC", Weight = 10.0f, Warranty = 12, CreatedAt = new DateTime(2024, 5, 12), Stock = 15 }
        ]);

        modelBuilder.Entity<PCComponents>().HasData([
            new PCComponents { PCId = 1, ComponentCode = "COMP-00001", Amount = 1 },
            new PCComponents { PCId = 1, ComponentCode = "COMP-00003", Amount = 1 },
            new PCComponents { PCId = 2, ComponentCode = "COMP-00002", Amount = 1 },
            new PCComponents { PCId = 3, ComponentCode = "COMP-00004", Amount = 1 },
            new PCComponents { PCId = 4, ComponentCode = "COMP-00005", Amount = 1 }
        ]);
    }
}