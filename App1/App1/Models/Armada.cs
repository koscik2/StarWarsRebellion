using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace StarWarsRebellion.Models
{
    public class Armada : INotifyPropertyChanged
    {
        private string _playerName;
        private ObservableCollection<Fleet> _fleets = new ObservableCollection<Fleet>();

        public string PlayerName { get => _playerName; set { _playerName = value; RaisePropertyChanged(); } }
        public Fleet ActiveFleet { get; set; }
        public ObservableCollection<Fleet> Fleets { get => _fleets; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Armada()
        {
            PlayerName = "Luke Skywalker";
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
