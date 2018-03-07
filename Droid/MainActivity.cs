using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CarouselView.FormsPlugin.Android;

namespace NorwegianCityRace.Droid
{
    [Activity(Label = "NorwegianCityRace.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
          //  TabLayoutResource = Resource.Layout.Tabbar;
          //  ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

           Plugin.CurrentActivity.CrossCurrentActivity.Current.Activity = this;
            global::Xamarin.Forms.Forms.Init(this, bundle);
            CarouselViewRenderer.Init();

            LoadApplication(new App());
          
        }
        // adding OnRequestPermissions Camera Use
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
