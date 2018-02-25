using System;
using System.Threading.Tasks;
using MvvmHelpers;
using NorwegianCityRace.Models;
using NorwegianCityRace.VIew;
using Plugin.Media;
using Xamarin.Forms;

namespace NorwegianCityRace.ViewModel
{
    public class FirstPageViewModel : BaseViewModel
    {
        public FirstPageViewModel()
        {

            TappedCommand = new Command(async () => await RunCamera());
            NextCommand = new Command(async () => await NextPage());
            

        }

      

        /*
        private GroupModel _model = new GroupModel();
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
        public string Name {
            set{
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
            get{
                return _name;
            }
        }

        ImageSource _picture = ImageSource.FromFile("grp_profile.png");
        public ImageSource Picture
        {
            set
            {
                _picture = value;
                OnPropertyChanged(nameof(Picture));
            }
            get
            {
                return _picture;
            }
        }


        public Command NextCommand { get; }

        //TapGestureRecognizer Start Camera on Tapped
        public Command TappedCommand { get; }


       async Task RunCamera(){

            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await Application.Current.MainPage.DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            await Application.Current.MainPage.DisplayAlert("File Location", file.Path, "OK");

            Picture = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });



        }

        //FIXME: 
      

        async Task NextPage(){
            GroupModel Model = new GroupModel()
            {
                Picture = Picture,
                Name = Name
            };


            await Application.Current.MainPage.DisplayAlert("Notification", Model.Name + Model.Picture, "Okay");
            await Application.Current.MainPage.Navigation.PushModalAsync(new SecondPage());
        }
    }
}

