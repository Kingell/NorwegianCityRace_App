using System;
using System.Collections.Generic;
using Plugin.Media;
using Xamarin.Forms;

namespace NorwegianCityRace.VIew
{
    public partial class FirstPage : ContentPage
    {
       

        public FirstPage()
        {
            InitializeComponent();

            take_picture_btn.Clicked += Handle_Clicked;
        }



        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await CrossMedia.Current.Initialize();
    
    if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
    {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
        return;
    }

    var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
    {
        Directory = "Sample",
        Name = "test.jpg"
    });

    if (file == null)
        return;

     await DisplayAlert("File Location", file.Path, "OK");

            grp_img.Source = ImageSource.FromStream(() =>
    {
        var stream = file.GetStream();
        return stream;
    }); 
        }

        void Next_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
