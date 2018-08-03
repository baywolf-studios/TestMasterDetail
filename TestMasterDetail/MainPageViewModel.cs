using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;

namespace TestMasterDetail
{
    public class MainPageViewModel
    {
        INavigationService _navigationService;

        public ICommand ViewACommand { get; set; }
        public ICommand ViewBCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ViewACommand = new DelegateCommand(Handle_TappedA);
            ViewBCommand = new DelegateCommand(Handle_TappedB);
        }

        async void Handle_TappedA()
        {
            await _navigationService.NavigateAsync("NavigationPage/ViewA");
        }

        async void Handle_TappedB()
        {
            await _navigationService.NavigateAsync("NavigationPage/ViewB");
        }
    }
}
