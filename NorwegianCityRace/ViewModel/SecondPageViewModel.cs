using System;
using MvvmHelpers;
using NorwegianCityRace.Models;
using Xamarin.Forms;

namespace NorwegianCityRace.ViewModel
{
    public class SecondPageViewModel: BaseViewModel
    {



        public SecondPageViewModel(){
            
        }

        public SecondPageViewModel(GroupModel model)
        {
            model.Name = _name;
            model.Picture = _picture;

        }

        /*private GroupModel _model { get; set; }
        public GroupModel Model{
            get{
                return _model;
            }
            set{
                _model = value;
                OnPropertyChanged();
            }
        }
        */

        string _name { get; set; }
        public string Name{
            get{
                return _name;
            }
            set{
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        ImageSource _picture { get; set; }
        public ImageSource Picture
        {
            get
            {
                return _picture;
            }
            set
            {
                _picture = value;
                OnPropertyChanged(nameof(Picture));
            }
        }




    }
}
