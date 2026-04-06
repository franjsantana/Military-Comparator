using MilitaryComparator.Models.Entities;

namespace MilitaryComparator.Services
{
    public class ComparisonState
    {
        public List<ArmoredVehicle> SelectedVehicles { get; private set; } = new();
        public const int MaxComparisonLimit = 4;

        public event Action? OnChange;

        public void AddVehicle(ArmoredVehicle vehicle)
        {
            if (SelectedVehicles.Count < MaxComparisonLimit)
            {
                SelectedVehicles.Add(vehicle);
                NotifyStateChanged();
            }
        }

        public void RemoveVehicle(int index)
        {
            if (index >= 0 && index < SelectedVehicles.Count)
            {
                SelectedVehicles.RemoveAt(index);
                NotifyStateChanged();
            }
        }

        public void Clear()
        {
            SelectedVehicles.Clear();
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
