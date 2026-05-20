using Microsoft.EntityFrameworkCore;
using PJATK_APBD_Cw4_s30734.DTOs;
using PJATK_APBD_Cw4_s30734.Infrastructre;
using PJATK_APBD_Cw4_s30734.Models;

namespace PJATK_APBD_Cw4_s30734.Services;

public class PCsService(DatabaseContext ctx) : IPCsService
{
    public async Task<IEnumerable<GetAllPCsResponseDTO>> GetAllPcs(CancellationToken cancellationToken)
    {
        return await ctx.PCs.Select(pc => new GetAllPCsResponseDTO(
            pc.Id,
            pc.Name,
            pc.Weight,
            pc.Warranty,
            pc.CreatedAt,
            pc.Stock
        )).ToListAsync(cancellationToken);
    }

    public async Task<PCsComponentsResponseDTO?> GetPCWithComponents(int id, CancellationToken cancellationToken)
    {
        return await ctx.PCs.Where(pc => pc.Id == id).Select(pc => new PCsComponentsResponseDTO(
            pc.Id,
            pc.Name,
            pc.Weight,
            pc.Warranty,
            pc.CreatedAt,
            pc.Stock,
            pc.PCComponents.Select(components => new PCComponentsDTO(
                components.Amount,
                new ComponentsDTO(
                    components.Component.Code,
                    components.Component.Name,
                    components.Component.Description,
                    new ComponentManufacturersDTO(
                        components.Component.ComponentManufacturer.Id,
                        components.Component.ComponentManufacturer.Abbreviation,
                        components.Component.ComponentManufacturer.FullName,
                        components.Component.ComponentManufacturer.FoundationDate),
                    new ComponentTypesDTO(
                        components.Component.ComponentType.Id,
                        components.Component.ComponentType.Abbreviation,
                        components.Component.ComponentType.Name)))))).FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<PCResponseDTO> AddPC(AddPCsRequestDTO pcRequestDto, CancellationToken cancellationToken)
    {
        PCs newPC = new PCs
        {
            Name = pcRequestDto.Name,
            Weight = pcRequestDto.Weight,
            Warranty = pcRequestDto.Warranty,
            CreatedAt = pcRequestDto.CreatedAt,
            Stock = pcRequestDto.Stock
        };
        ctx.PCs.Add(newPC);
        await ctx.SaveChangesAsync(cancellationToken);
        
        return new PCResponseDTO(
            newPC.Id,
            newPC.Name,
            newPC.Weight,
            newPC.Warranty,
            newPC.CreatedAt,
            newPC.Stock);
    }

    public async Task<PCResponseDTO?> UpdatePC(int id, UpdatePCsRequestDTO updatePcRequestDto, CancellationToken cancellationToken)
    {
        PCs? updatedPC = await ctx.PCs.Where(pc => pc.Id == id).FirstOrDefaultAsync(cancellationToken);
        if (updatedPC == null)
            return null;
        
        updatedPC.Name = updatePcRequestDto.Name;
        updatedPC.Weight = updatePcRequestDto.Weight;
        updatedPC.Warranty = updatePcRequestDto.Warranty;
        updatedPC.CreatedAt = updatePcRequestDto.CreatedAt;
        updatedPC.Stock = updatePcRequestDto.Stock;
        
        await ctx.SaveChangesAsync(cancellationToken);
        
        return new PCResponseDTO(
            updatedPC.Id,
            updatedPC.Name,
            updatedPC.Weight,
            updatedPC.Warranty,
            updatedPC.CreatedAt,
            updatedPC.Stock);
    }

    public async Task<bool> DeletePC(int id, CancellationToken cancellationToken)
    {
        int deletedRows = await ctx.PCs.Where(pc => pc.Id == id).ExecuteDeleteAsync(cancellationToken);
        return deletedRows > 0;
    }
}