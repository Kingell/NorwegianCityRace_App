using System;
using NorwegianCityRace.ViewModel;
using Xamarin.Forms;

// Last update 23.02.18
namespace NorwegianCityRace.VIew
{
    public partial class NorwegianCityRacePage : ContentPage
    {
        public NorwegianCityRacePage()
        {
            InitializeComponent();
            BindingContext = new NorwegianCityRaceViewModel();
        }




     
    }
}
