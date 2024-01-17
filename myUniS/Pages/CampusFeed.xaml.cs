using Microsoft.Maui.Controls;

namespace myUniS
{
    public partial class CampusFeed : ContentPage
    {
        public CampusFeed()
        {
            InitializeComponent();
        }

        private void OnSearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("ERROR", "Wala pang Backend", "OK");
        }

        private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
