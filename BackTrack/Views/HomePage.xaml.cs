using System;
using System.Collections.Generic;
using BackTrack.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BackTrack.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        readonly HomeViewModel viewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new HomeViewModel();
        }


        void OnButtonClicked(object sender, EventArgs e){
            DisplayAlert("Title Message", "Main body message goes here!","close");
        }
    }
}
