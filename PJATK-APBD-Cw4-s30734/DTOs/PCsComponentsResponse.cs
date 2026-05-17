using PJATK_APBD_Cw4_s30734.Models;

namespace PJATK_APBD_Cw4_s30734.DTOs;

public record PCsComponentsResponse(int Id,
    string Name,
    float Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock,
    IEnumerable<PCComponents> PCComponents);