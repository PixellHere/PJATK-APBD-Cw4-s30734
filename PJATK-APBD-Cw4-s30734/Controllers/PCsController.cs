using Microsoft.AspNetCore.Mvc;
using PJATK_APBD_Cw4_s30734.DTOs;
using PJATK_APBD_Cw4_s30734.Services;

namespace PJATK_APBD_Cw4_s30734.Controllers;

[ApiController]
[Route("api/pcs")]
public class PCsController(IPCsService service) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAllPCs(CancellationToken cancellationToken)
    {
        return Ok(await service.GetAllPcs(cancellationToken));
    }
    
    [HttpGet("{id:int}/components")]
    public async Task<IActionResult> GetByIdWithComponents([FromRoute]int id, CancellationToken cancellationToken)
    {
        PCsComponentsResponseDTO? pc = await service.GetPCWithComponents(id, cancellationToken);
        if (pc == null)
            return NotFound();
        else
            return Ok(pc);
    }
    
    [HttpPost]
    public async Task<IActionResult> AddNewPC([FromBody] AddPCsRequestDTO addPCRequestDto, CancellationToken cancellationToken)
    {
        PCResponseDTO newPc = await service.AddPC(addPCRequestDto, cancellationToken);
        return CreatedAtAction(nameof(GetByIdWithComponents), new {id = newPc.Id}, newPc);
    }
    
    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdatePC([FromRoute]int id, [FromBody] UpdatePCsRequestDTO updatePCRequestDto, CancellationToken cancellationToken)
    {
        PCResponseDTO? pc = await service.UpdatePC(id, updatePCRequestDto, cancellationToken);
        
        if (pc == null)
            return NotFound();
        else
            return Ok(pc);
    }
    
    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeletePC([FromRoute]int id, CancellationToken cancellationToken)
    {
        bool isDeleted = await service.DeletePC(id, cancellationToken);
        
        return isDeleted ? NoContent() : NotFound();
    }
}