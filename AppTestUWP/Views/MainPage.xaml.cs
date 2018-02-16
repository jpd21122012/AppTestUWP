using System;

using AppTestUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AppTestUWP.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
