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
	public partial class ModalPage : ContentPage
	{
		public ModalPage ()
		{
			InitializeComponent ();
		}

	    async void Handle_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PopModalAsync();
	    }

	    protected override bool OnBackButtonPressed()
	    {
	        return true;
	    }
    }
}