using App1.ViewModels;
using StarWarsRebellion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArmadaPage : ContentPage
    {
        public ArmadaPage()
        {
            InitializeComponent();
        }

        private void changeNameButton_Clicked(object sender, EventArgs e)
        {
            if (playerLabel.IsVisible)
            {
                playerLabel.IsVisible = false;
                playerEntry.IsVisible = true;
                changeNameButton.Text = "Zapisz";
            }
            else
            {
                playerLabel.IsVisible = true;
                playerEntry.IsVisible = false;
                changeNameButton.Text = "Zmień nazwę";
            }
        }        

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            FleetPage fp = new FleetPage() { BindingContext = new FleetViewModel() { LocalFleet = (Fleet)e.Item } };
            Navigation.PushAsync(fp);
        }
    }
}