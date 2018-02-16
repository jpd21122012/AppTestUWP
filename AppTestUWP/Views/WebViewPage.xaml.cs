using System;

using AppTestUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AppTestUWP.Views
{
    public sealed partial class WebViewPage : Page
    {
        public WebViewViewModel ViewModel { get; } = new WebViewViewModel();

        public WebViewPage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
