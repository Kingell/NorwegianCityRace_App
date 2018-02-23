using System;
using System.Collections.Generic;
using NorwegianCityRace.Models;
using NorwegianCityRace.ViewModel;
using Plugin.Media;
using Xamarin.Forms;

namespace NorwegianCityRace.VIew
{
    public partial class FirstPage : ContentPage
    {


        public FirstPage()
        {
            InitializeComponent();

            BindingContext = new FirstPageViewModel();
        }


       




    }
}
