using Microsoft.EntityFrameworkCore;
using MilitaryComparator.Data;
using MilitaryComparator.Models.Entities;
using MilitaryComparator.Models.Enums;

namespace MilitaryComparator.Services
{
    public class MilitaryDataService : IMilitaryDataService
    {
        private readonly IDbContextFactory<MilitaryDbContext> _dbFactory;

        public MilitaryDataService(IDbContextFactory<MilitaryDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Nation>> GetAllNationsAsync()
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.Nations
                .Include(n => n.Vehicles)
                .ToListAsync();
        }

        public async Task<Nation?> GetNationByIdAsync(int id)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.Nations
                .Include(n => n.Vehicles)
                .FirstOrDefaultAsync(n => n.Id == id);
        }

        public async Task<List<ArmoredVehicle>> GetAllVehiclesAsync()
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.ArmoredVehicles
                .Include(v => v.Nation)
                .ToListAsync();
        }

        public async Task<List<ArmoredVehicle>> GetVehiclesByTypeAsync(VehicleType type)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.ArmoredVehicles
                .Include(v => v.Nation)
                .Where(v => v.VehicleType == type)
                .ToListAsync();
        }

        public async Task<List<ArmoredVehicle>> GetVehiclesByNationAsync(int nationId)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.ArmoredVehicles
                .Include(v => v.Nation)
                .Where(v => v.NationId == nationId)
                .ToListAsync();
        }

        public async Task<ArmoredVehicle?> GetVehicleByIdAsync(int id)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            return await context.ArmoredVehicles
                .Include(v => v.Nation)
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task AddVehicleAsync(ArmoredVehicle vehicle)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            await context.ArmoredVehicles.AddAsync(vehicle);
            await context.SaveChangesAsync();
        }

        public async Task UpdateVehicleAsync(ArmoredVehicle vehicle)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            context.ArmoredVehicles.Update(vehicle);
            await context.SaveChangesAsync();
        }

        public async Task DeleteVehicleAsync(int id)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            var vehicle = await context.ArmoredVehicles.FindAsync(id);
            if (vehicle != null)
            {
                context.ArmoredVehicles.Remove(vehicle);
                await context.SaveChangesAsync();
            }
        }

        public async Task AddNationAsync(Nation nation)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            await context.Nations.AddAsync(nation);
            await context.SaveChangesAsync();
        }

        public async Task UpdateNationAsync(Nation nation)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            context.Nations.Update(nation);
            await context.SaveChangesAsync();
        }

        public async Task DeleteNationAsync(int id)
        {
            using var context = await _dbFactory.CreateDbContextAsync();
            var nation = await context.Nations.FindAsync(id);
            if (nation != null)
            {
                context.Nations.Remove(nation);
                await context.SaveChangesAsync();
            }
        }
    }
}