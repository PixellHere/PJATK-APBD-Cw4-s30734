namespace PJATK_APBD_Cw4_s30734.DTOs;

public record PCResponseDTO(
    int Id,
    string Name,
    float Weight,
    int Warranty,
    DateTime CreatedAt,
    int Stock);