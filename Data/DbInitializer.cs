using Microsoft.EntityFrameworkCore;
using MilitaryComparator.Models.Entities;
using MilitaryComparator.Models.Enums;

namespace MilitaryComparator.Data
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(MilitaryDbContext context)
        {
            await context.Database.EnsureCreatedAsync();

            if (await context.Nations.AnyAsync())
            {
                return; // DB has been seeded
            }

            // Seed Nations
            var nations = new List<Nation>
            {
                new Nation { 
                    Name = "España", 
                    Description = "España posee una fuerza armada moderna con tecnología avanzada, destacando su industria naval y vehículos blindados de fabricación nacional y en colaboración con la OTAN.",
                    FlagImageUrl = "https://flagcdn.com/w320/es.png"
                },
                new Nation { 
                    Name = "EE.UU.", 
                    Description = "Estados Unidos mantiene la fuerza militar más tecnológicamente avanzada y con mayor capacidad de proyección a nivel global.",
                    FlagImageUrl = "https://flagcdn.com/w320/us.png"
                },
                new Nation { 
                    Name = "Alemania", 
                    Description = "Alemania es referente mundial en ingeniería blindada, con el Leopard 2 como estándar de excelencia en la OTAN.",
                    FlagImageUrl = "https://flagcdn.com/w320/de.png"
                }
            };

            await context.Nations.AddRangeAsync(nations);
            await context.SaveChangesAsync();

            // Seed Vehicles
            var vehicles = new List<ArmoredVehicle>
            {
                // España
                new ArmoredVehicle
                {
                    Name = "Leopardo 2E",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1a/Leopardo_2E_S_C_2008.jpg/400px-Leopardo_2E_S_C_2008.jpg",
                    VehicleType = VehicleType.MBT,
                    Year = 2004,
                    Length = 9.67, Width = 3.75, Height = 3.0,
                    Weight = 62.5,
                    Engine = "MTU MB 873 Ka-501", EnginePower = 1500,
                    Transmission = "Renk HSWL 354",
                    MaxSpeedRoad = 70, MaxSpeedOffRoad = 45,
                    Suspension = "Barras de torsión",
                    Range = 500,
                    MainArmament = "L55 120 mm Rheinmetall", SecondaryArmament = "2x 7.62 mm MG3",
                    Armor = "Blindaje compuesto de 3ª generación",
                    Crew = 4, Passengers = 0,
                    TotalProduced = 219,
                    NationId = nations[0].Id
                },
                new ArmoredVehicle
                {
                    Name = "Pizarro",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Pizarro_VCI-C-2.jpg/400px-Pizarro_VCI-C-2.jpg",
                    VehicleType = VehicleType.APC,
                    Year = 1996,
                    Length = 6.22, Width = 3.64, Height = 2.43,
                    Weight = 28.0,
                    Engine = "MTU 8V 183 TE22", EnginePower = 600,
                    Transmission = "Renk HSWL 106",
                    MaxSpeedRoad = 70, MaxSpeedOffRoad = 35,
                    Suspension = "Barras de torsión",
                    Range = 500,
                    MainArmament = "Mauser 30 mm MK 30-2", SecondaryArmament = "7.62 mm MG3",
                    Armor = "Acero balístico",
                    Crew = 3, Passengers = 8,
                    TotalProduced = 261,
                    NationId = nations[0].Id
                },
                // EE.UU.
                new ArmoredVehicle
                {
                    Name = "M1A2 Abrams",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0c/M1A1_abrams_front.jpg/400px-M1A1_abrams_front.jpg",
                    VehicleType = VehicleType.MBT,
                    Year = 1992,
                    Length = 9.77, Width = 3.66, Height = 2.44,
                    Weight = 66.8,
                    Engine = "Honeywell AGT1500 Turbina", EnginePower = 1500,
                    Transmission = "Allison X-1100-3B",
                    MaxSpeedRoad = 67, MaxSpeedOffRoad = 48,
                    Suspension = "Barras de torsión",
                    Range = 426,
                    MainArmament = "M256 120 mm L/44", SecondaryArmament = "12.7 mm M2HB, 2x 7.62 mm M240",
                    Armor = "Chobham, UR empobrecido",
                    Crew = 4, Passengers = 0,
                    TotalProduced = 10000,
                    NationId = nations[1].Id
                },
                new ArmoredVehicle
                {
                    Name = "M2 Bradley",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/be/M2A3_Bradley_IFV.jpg/400px-M2A3_Bradley_IFV.jpg",
                    VehicleType = VehicleType.APC,
                    Year = 1981,
                    Length = 6.55, Width = 3.60, Height = 2.98,
                    Weight = 27.6,
                    Engine = "Cummins VTA-903-T600", EnginePower = 600,
                    Transmission = "HMPT-500",
                    MaxSpeedRoad = 61, MaxSpeedOffRoad = 40,
                    Suspension = "Barras de torsión",
                    Range = 480,
                    MainArmament = "M242 25 mm Bushmaster", SecondaryArmament = "TOW, 7.62 mm M240",
                    Armor = "Espaciado laminado, aluminio",
                    Crew = 3, Passengers = 6,
                    NationId = nations[1].Id
                },
                // Alemania
                new ArmoredVehicle
                {
                    Name = "Leopard 2A7",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/f6/Leopard_2A7.jpg/400px-Leopard_2A7.jpg",
                    VehicleType = VehicleType.MBT,
                    Year = 2014,
                    Length = 10.97, Width = 3.76, Height = 3.0,
                    Weight = 67.5,
                    Engine = "MTU MB 873 Ka-501", EnginePower = 1500,
                    Transmission = "Renk HSWL 354",
                    MaxSpeedRoad = 72, MaxSpeedOffRoad = 45,
                    Suspension = "Barras de torsión",
                    Range = 450,
                    MainArmament = "L55 120 mm Rheinmetall", SecondaryArmament = "2x 7.62 mm MG3",
                    Armor = "Compuesto avanzado frontal",
                    Crew = 4, Passengers = 0,
                    NationId = nations[2].Id
                }
            };

            await context.ArmoredVehicles.AddRangeAsync(vehicles);
            await context.SaveChangesAsync();
        }
    }
}
