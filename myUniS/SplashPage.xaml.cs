using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace myUniS
{
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            InitializeApp();
        }

        async void InitializeApp()
        {
            // Simulate some loading time (e.g., 2 seconds)
            await Task.Delay(3000);

            // Navigate to your main page (AppShell or MainPage)
            Application.Current.MainPage = new AppShell();  // or any other main page
        }
    }
}
