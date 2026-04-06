using MilitaryComparator.Models.Entities;

namespace MilitaryComparator.Models.ViewModels
{
    public class ComparisonViewModel // modelo de vista para la comparacion de vehiculos blindados
    {
        public List<VehicleComparisonItem> Vehicles { get; set; } = new(); // lista de vehiculos blindados
        public int MaxComparisons { get; set; } = 4; // numero maximo de vehiculos blindados a comparar
    }

    public class VehicleComparisonItem // item de comparacion de vehiculos blindados
    {
        public ArmoredVehicle? Vehicle { get; set; } // vehiculo blindado
        public Nation? Nation { get; set; } // nacion
        public string DisplayName => $"{Nation?.Name} - {Vehicle?.Name}"; // nombre del vehiculo blindado
    }
}