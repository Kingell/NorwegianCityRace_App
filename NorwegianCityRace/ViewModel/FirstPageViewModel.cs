using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using MvvmHelpers;
using NorwegianCityRace.Models;
using NorwegianCityRace.MvvmHelpers;
using NorwegianCityRace.VIew;
using Plugin.Media;
using Xamarin.Forms;


namespace NorwegianCityRace.ViewModel
{
    public class FirstPageViewModel : BaseViewModel
    {
        public FirstPageViewModel()
        {

        }


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


        //FIXME: legg til send metode for å sende til database før navigere videre til neste side.

        public RelayCommand NextCommand { get{

                return new RelayCommand( async() =>
                {
                    GroupModel Model = new GroupModel()
                    {
                        Picture = Picture,
                        Name = Name
                    };


                    await Application.Current.MainPage.DisplayAlert("Notification", Model.Name + Model.Picture, "Okay");
                    var nav = SimpleIoc.Default.GetInstance<INavigationService>();
                    nav.NavigateTo("SecondPage",Model);
                });
            } }



        //TapGestureRecognizer Start Camera on Tapped
        public RelayCommand TappedCommand
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    await RunCamera();
                });
            }
        }


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

       

    }
}

