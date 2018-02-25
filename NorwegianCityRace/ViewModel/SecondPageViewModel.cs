using System;
using MvvmHelpers;
using NorwegianCityRace.Models;
using Xamarin.Forms;

namespace NorwegianCityRace.ViewModel
{
    public class SecondPageViewModel: BaseViewModel
    {




        public SecondPageViewModel()
        {
            
        }

        private GroupModel _model { get; set; }
        public GroupModel Model{
            get{
                return _model;
            }
            set{
                _model = value;
                OnPropertyChanged();
            }
        }





    }
}
