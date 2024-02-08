namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var newPage = new NavigationPage(new MainPage());

            MainPage = new PrintDemoPage();
        }
    }
}
