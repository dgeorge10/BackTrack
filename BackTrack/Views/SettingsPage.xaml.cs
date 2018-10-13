using System;
using System.Collections.Generic;
using BackTrack.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackTrack.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        readonly SettingsViewModel viewModel;

        public SettingsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new SettingsViewModel();

        }
    }
}
