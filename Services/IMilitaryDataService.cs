using MilitaryComparator.Models.Entities;
using MilitaryComparator.Models.Enums;

namespace MilitaryComparator.Services
{
    public interface IMilitaryDataService // interfaz para el servicio de datos militares
    {
        Task<List<Nation>> GetAllNationsAsync(); // obtener todas las naciones
        Task<Nation?> GetNationByIdAsync(int id); // obtener nacion por id
        Task<List<ArmoredVehicle>> GetAllVehiclesAsync(); // obtener todos los vehiculos blindados
        Task<List<ArmoredVehicle>> GetVehiclesByTypeAsync(VehicleType type); // obtener vehiculos blindados por tipo
        Task<List<ArmoredVehicle>> GetVehiclesByNationAsync(int nationId); // obtener vehiculos blindados por nacion
        Task<ArmoredVehicle?> GetVehicleByIdAsync(int id); // obtener vehiculo blindado por id
        
        // CRUD Operations
        Task AddVehicleAsync(ArmoredVehicle vehicle);
        Task UpdateVehicleAsync(ArmoredVehicle vehicle);
        Task DeleteVehicleAsync(int id);
        
        Task AddNationAsync(Nation nation);
        Task UpdateNationAsync(Nation nation);
        Task DeleteNationAsync(int id);
    }
}