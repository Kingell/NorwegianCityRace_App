using System;
using System.Collections.Generic;
using NorwegianCityRace.Models;
using NorwegianCityRace.ViewModel;
using Xamarin.Forms;

namespace NorwegianCityRace.VIew
{
    public partial class SecondPage : ContentPage
    {

       
        public SecondPage()
        {
            InitializeComponent();
            BindingContext = new SecondPageViewModel();

           

          

        }



       
          
    }
}
