using StarWarsRebellion.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace StarWarsRebellion.ViewModels
{
    public class ArmadaViewModel : BaseViewModel
    {
        private Armada _localArmada;

        public string PlayerName { get => _localArmada.PlayerName; set { _localArmada.PlayerName = value; OnPropertyChanged(); } }
        public Fleet ActiveFleet { get => _localArmada.ActiveFleet; set => _localArmada.ActiveFleet = value; }
        public ObservableCollection<Fleet> Fleets { get => _localArmada.Fleets; }
        public ICommand NewFleetCommand { get; }


        public ArmadaViewModel()
        {
            _localArmada = DependencyService.Resolve<Armada>();
            NewFleetCommand = new Command(new Action<object>((arg) =>
            {
                AddFleet();
            }), new Func<object, bool>(p => true));
        }

        private void AddFleet()
        {
            _localArmada.Fleets.Add(new Fleet());
        }
    }
}
