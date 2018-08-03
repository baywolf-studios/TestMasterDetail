using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;

namespace TestMasterDetail
{
    public partial class ViewA : ContentPage
    {
        async void Handle_Tapped(object sender, System.EventArgs e)
        {
            try
            {
                await _navigationService.NavigateAsync("SubViewA");
            }
            catch(Exception ex)
            {
                var test = ex;
            }
        }

        INavigationService _navigationService;

        public ViewA(INavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }
    }
}
