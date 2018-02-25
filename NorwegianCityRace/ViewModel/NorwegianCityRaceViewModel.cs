using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace NorwegianCityRace.ViewModel
{
    public class NorwegianCityRaceViewModel
    {
        public NorwegianCityRaceViewModel()
        {


        }


        public RelayCommand FirstPage
        {
            get
            {
                return new RelayCommand(() =>
                {
                    var navigation = SimpleIoc.Default.GetInstance<INavigationService>();
                    navigation.NavigateTo("FirstPage");
                });
            }
        }

    }
}
