using System;
using TrainingApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
		    var loginViewModel = new LoginViewModel();
		    BindingContext = loginViewModel;
		    loginViewModel.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");

		    InitializeComponent();

		    Email.Completed += (object sender, EventArgs e) =>
		    {
		        Password.Focus();
		    };

		    Password.Completed += (object sender, EventArgs e) =>
		    {
		        loginViewModel.SubmitCommand.Execute(null);
		    };
        }
	}
}