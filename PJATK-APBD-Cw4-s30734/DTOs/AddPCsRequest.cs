using System.ComponentModel.DataAnnotations;

namespace PJATK_APBD_Cw4_s30734.DTOs;

public record AddPCsRequest(
    [MaxLength(50)] string Name,
    float Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock);