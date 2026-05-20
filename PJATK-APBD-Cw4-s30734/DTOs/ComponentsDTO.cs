namespace PJATK_APBD_Cw4_s30734.DTOs;

public record ComponentsDTO(
    string Code, 
    string Name, 
    string Description, 
    ComponentManufacturersDTO Manufacturer, 
    ComponentTypesDTO Type);