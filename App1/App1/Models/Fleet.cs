using App1.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StarWarsRebellion.Models
{
    public class Fleet : INotifyPropertyChanged
    {
        private string _fleetName;
        private ObservableCollection<Ship> _ships = new ObservableCollection<Ship>();

        public string FleetName { get => _fleetName; set { _fleetName = value; RaisePropertyChanged(); } }
        public int ShipCount { get => _ships.Count; }
        public ObservableCollection<Ship> Ships { get => _ships; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public Fleet()
        {
            FleetName = "Flota 1";
        }
    }
}
