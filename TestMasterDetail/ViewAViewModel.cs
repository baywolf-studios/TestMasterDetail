using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;

namespace TestMasterDetail
{
    public class ViewAViewModel
    {
        INavigationService _navigationService;

        public ICommand SubViewACommand { get; set; }

        public ViewAViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            SubViewACommand = new DelegateCommand(Handle_Tapped);
        }

        async void Handle_Tapped()
        {
            await _navigationService.NavigateAsync("SubViewA");
        }
    }
}
