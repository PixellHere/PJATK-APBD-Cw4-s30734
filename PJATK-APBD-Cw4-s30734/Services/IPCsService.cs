using PJATK_APBD_Cw4_s30734.DTOs;

namespace PJATK_APBD_Cw4_s30734.Services;

public interface IPCsService
{
    public Task<IEnumerable<GetAllPCsResponseDTO>> getAllPcs(CancellationToken cancellationToken);
    public Task<PCsComponentsResponseDTO?> getPCWithComponents(int id, CancellationToken cancellationToken);
    public Task<PCResponseDTO> addPC(AddPCsRequestDTO pcRequestDto, CancellationToken cancellationToken);
    public Task<PCResponseDTO>  updatePC(int id, UpdatePCsRequestDTO updatePcRequestDto,  CancellationToken cancellationToken);
    public Task<bool> deletePC(int id,  CancellationToken cancellationToken);
}