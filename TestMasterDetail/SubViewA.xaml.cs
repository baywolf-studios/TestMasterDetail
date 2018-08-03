using System;
using System.Collections.Generic;
using Prism.Navigation;
using Xamarin.Forms;

namespace TestMasterDetail
{
    public partial class SubViewA : ContentPage
    {
        INavigationService _navigationService;

        public SubViewA(INavigationService navigationService)
        {
            InitializeComponent();
            _navigationService = navigationService;
        }
    }
}
