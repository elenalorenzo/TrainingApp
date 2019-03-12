using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActionSheetCall : ContentPage
	{
		public ActionSheetCall ()
		{
			InitializeComponent ();
		}

	    async void Handle_Clicked(object sender, EventArgs e)
	    {
	        var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
	        await DisplayAlert("Response", response, "OK");
	    }
	}
}