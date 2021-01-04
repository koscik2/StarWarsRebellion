using StarWarsRebellion.Models;
using StarWarsRebellion.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class FleetViewModel : BaseViewModel
    {
        public Fleet LocalFleet { get; set; }
        public string FleetName { get => LocalFleet?.FleetName ?? string.Empty; set { if (LocalFleet != null) LocalFleet.FleetName = value; OnPropertyChanged(); } }

        public FleetViewModel()
        {
                      
        }
    }
}
