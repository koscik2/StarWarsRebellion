using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.Models
{
    public abstract class Ship : ShipComponent
    {
        private ObservableCollection<ShipComponent> _components = new ObservableCollection<ShipComponent>();

        public ObservableCollection<ShipComponent> Components { get => _components; }
    }
}
