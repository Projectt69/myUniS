namespace myUniS
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("Settings", typeof(Settings));
            Routing.RegisterRoute("Organizations", typeof(Organizations));
            Routing.RegisterRoute("EventCalendar", typeof(EventCalendar));
            Routing.RegisterRoute("Profile", typeof(Profile));

        }
        private async void GoSettings(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Settings");
        }
        private async void GoOrganizations(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Organizations");
        }
        private async void GoEventCalendar(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("EventCalendar");
        }
        private async void GoProfile(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("Profile");
        }


    }
}
