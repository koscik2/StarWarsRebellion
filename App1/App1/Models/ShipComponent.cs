using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace App1.Models
{
    public abstract class ShipComponent : INotifyPropertyChanged
    {
        protected byte _redHealth;
        protected byte _grayHealth;
        protected string _name;

        public byte RedHealth { get => _redHealth; set { _redHealth = value; RaisePropertyChanged(); } }
        public byte GreyHealth { get => _grayHealth; set { _grayHealth = value; RaisePropertyChanged(); } }
        public string Name { get => _name; set { _name = value; RaisePropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
