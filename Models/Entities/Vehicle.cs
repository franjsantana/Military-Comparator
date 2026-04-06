using MilitaryComparator.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MilitaryComparator.Models.Entities
{
    public class ArmoredVehicle
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public int Year { get; set; } // año en servicio

        public string ImageUrl { get; set; } = string.Empty;

        public VehicleType VehicleType { get; set; }

        // Dimensions
        public double? Length { get; set; } // meters
        public double? Width { get; set; } // meters
        public double? Height { get; set; } // meters

        public double? Weight { get; set; } // tons

        // Propulsion
        public string Engine { get; set; } = string.Empty;
        public int? EnginePower { get; set; } // hp
        public string Transmission { get; set; } = string.Empty;

        // Performance
        public int? MaxSpeedRoad { get; set; } // km/h
        public int? MaxSpeedOffRoad { get; set; } // km/h
        public string Suspension { get; set; } = string.Empty; // suspension
        public int? Range { get; set; } // km

        // Armament
        public string MainArmament { get; set; } = string.Empty; // armamento principal
        public string SecondaryArmament { get; set; } = string.Empty; // armamento secundario

        // Armor
        public string Armor { get; set; } = string.Empty; // blindaje

        public int Crew { get; set; } // numero de tripulantes
        public int? Passengers { get; set; } // capacidad de infantería / pasajeros

        // Production
        public int? TotalProduced { get; set; } // numero de unidades producidas

        // Foreign keys
        public int NationId { get; set; }
        public Nation? Nation { get; set; }
    }
}