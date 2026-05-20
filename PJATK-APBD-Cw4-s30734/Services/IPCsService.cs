using PJATK_APBD_Cw4_s30734.DTOs;

namespace PJATK_APBD_Cw4_s30734.Services;

public interface IPCsService
{
    public Task<IEnumerable<GetAllPCsResponseDTO>> GetAllPcs(CancellationToken cancellationToken);
    public Task<PCsComponentsResponseDTO?> GetPCWithComponents(int id, CancellationToken cancellationToken);
    public Task<PCResponseDTO> AddPC(AddPCsRequestDTO pcRequestDto, CancellationToken cancellationToken);
    public Task<PCResponseDTO> UpdatePC(int id, UpdatePCsRequestDTO updatePcRequestDto,  CancellationToken cancellationToken);
    public Task<bool> DeletePC(int id,  CancellationToken cancellationToken);
}