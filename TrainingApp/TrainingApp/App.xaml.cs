using System;
using TrainingApp.Pages;
using TrainingApp.Pages.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TrainingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new QuotesPage();
            //MainPage = new LoginPage();
            //MainPage = new StackLayoutPage();
            //MainPage = new GridPage();
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new RelativeLayoutPage();
            //MainPage = new ImagePage();
            //MainPage = new IconPage();
            MainPage = new RoundedImagePage();
            //MainPage = new ActivityIndicatorPage();
            //MainPage = new ListPage();
            //MainPage = new ContactListPage();
            //MainPage = new FollowListPage();
            //MainPage = new GroupListPage();
            //MainPage = new SelectableListPage();
            //MainPage = new ContextActionsListPage();
            //MainPage = new RefreshListPage();
            //MainPage = new SearchBarListPage();
            //MainPage = new NavigationPage(new HierarchicalNavigationPage());
            //MainPage = new NavigationPage(new ContactsPage());
            //MainPage = new ContactMasterDetailPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
