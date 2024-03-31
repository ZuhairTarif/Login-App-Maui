using ERPMaui.Pages;

namespace ERPMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var token = Preferences.Get("token", string.Empty);

            if(string.IsNullOrEmpty(token))
            {
                MainPage = new NavigationPage(new LoginPage());

            }
            else
            {
                MainPage = new AppShell();
            }

            
        }
    }
}
