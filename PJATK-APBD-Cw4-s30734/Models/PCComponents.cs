using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PJATK_APBD_Cw4_s30734.Models;

[Table("PCComponents")][PrimaryKey(nameof(PCId),nameof(ComponentCode))]
public class PCComponents
{
    public int PCId { get; set; }
    public string ComponentCode { get; set; } = string.Empty;
    public int Amount { get; set; }

    [ForeignKey(nameof(PCId))] 
    public PCs Pcs { get; set; } = null!;

    [ForeignKey(nameof(ComponentCode))] 
    public Components Component { get; set; } = null!;
}