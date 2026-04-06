using System.ComponentModel.DataAnnotations;

namespace MilitaryComparator.Models.Entities
{
    public class Nation
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string FlagImageUrl { get; set; } = string.Empty;

        public ICollection<ArmoredVehicle> Vehicles { get; set; } = new List<ArmoredVehicle>(); // vehiculos blindados
    }
}