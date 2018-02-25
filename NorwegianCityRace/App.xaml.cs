using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using NorwegianCityRace.MvvmHelpers;
using Xamarin.Forms;

namespace NorwegianCityRace
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            var navigationPage = new NavigationPage();
            var navigationService = new NavigationService();
            navigationService.Initialize(navigationPage);

            navigationService.Configure("Main",typeof(VIew.NorwegianCityRacePage));
            navigationService.Configure("FirstPage",typeof(VIew.FirstPage));
            navigationService.Configure("SecondPage",typeof(VIew.SecondPage));

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            //SimpleIoc.Default.Register<IDialogService>(() => new DialogService());

            navigationPage.PushAsync(new VIew.NorwegianCityRacePage());

            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
