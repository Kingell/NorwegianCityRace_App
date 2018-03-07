
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

            //INavigationService navigationService;
            NavigationService navigationService;

            if (!SimpleIoc.Default.IsRegistered<INavigationService>())
            {
                // Setup navigation service:
                navigationService = new NavigationService();

                // Configure pages:
                navigationService.Configure("Main", typeof(VIew.NorwegianCityRacePage));
                navigationService.Configure("FirstPage", typeof(VIew.FirstPage));
                navigationService.Configure("SecondPage", typeof(VIew.SecondPage));

                // Register NavigationService in IoC container:

                SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            }

            else
                navigationService =(NavigationService)SimpleIoc.Default.GetInstance<INavigationService>();

            // Create new Navigation Page and set MainPage as its default page:
            var firstPage = new NavigationPage(new VIew.NorwegianCityRacePage());
            // Set Navigation page as default page for Navigation Service:
            navigationService.Initialize(firstPage);
            // You have to also set MainPage property for the app:
            MainPage = firstPage;
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
