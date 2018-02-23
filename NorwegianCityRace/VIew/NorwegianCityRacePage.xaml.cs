using System;
using Xamarin.Forms;

// Last update 23.02.18
namespace NorwegianCityRace.VIew
{
    public partial class NorwegianCityRacePage : ContentPage
    {
        public NorwegianCityRacePage()
        {
            InitializeComponent();
        }




        async void Enter_btn_clicked(object sender, EventArgs e)
        {
            //TODO : PIN CODE

            await Navigation.PushModalAsync(new FirstPage());
        }
    }
}
