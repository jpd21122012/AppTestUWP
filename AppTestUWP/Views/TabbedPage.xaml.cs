using System;

using AppTestUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AppTestUWP.Views
{
    public sealed partial class TabbedPage : Page
    {
        public TabbedViewModel ViewModel { get; } = new TabbedViewModel();

        public TabbedPage()
        {
            InitializeComponent();
        }
    }
}
