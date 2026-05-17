using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PJATK_APBD_Cw4_s30734.Models;

[Table("Components")]
public class Components
{
    [Key][Column(TypeName = "char(10)")]
    public string Code { get; set; } = string.Empty;
    
    [MaxLength(300)]
    public string Name { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;
    
    public int ComponentManufacturersId { get; set; }
    public int ComponentTypesId { get; set; }

    [ForeignKey(nameof(ComponentManufacturersId))]
    public ComponentManufacturers ComponentManufacturer { get; set; } = null!;

    [ForeignKey(nameof(ComponentTypesId))] 
    public ComponentTypes ComponentType { get; set; } = null!;
    
    public IEnumerable<PCComponents> PCComponents { get; set; } = [];
}