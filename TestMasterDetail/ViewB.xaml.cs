using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;

namespace TestMasterDetail
{
    public partial class ViewB : ContentPage
    {
        INavigationService _navigationService;

        public ViewB(INavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }
    }
}
