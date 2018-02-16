using AppTestUWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace AppTestUWP.Views
{
    public sealed partial class CameraPage : Page
    {
        public CameraViewModel ViewModel { get; } = new CameraViewModel();

        public CameraPage()
        {
            InitializeComponent();
        }
    }
}
