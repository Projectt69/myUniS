namespace myUniS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Optionally, you can perform any initialization here before transitioning to the Shell.
            // Once the initialization is complete, set the MainPage to your Shell.
            // MainPage = new AppShell();

            // For simplicity, transitioning to AppShell immediately after the splash screen.
            MainPage = new NavigationPage(new SplashPage());
           
        }
    }
}
