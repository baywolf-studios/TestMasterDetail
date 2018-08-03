using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DryIoc;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Services;
using Prism.AppModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestMasterDetail
{
    public partial class App : PrismApplication
    {
        public App() : base(null) { }
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<SubViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("/MainPage/NavigationPage/ViewA");
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
