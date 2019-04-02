using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.DataAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppProperties : ContentPage
	{
		public AppProperties ()
		{
			InitializeComponent ();
		    BindingContext = Application.Current;
		}

        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //}

        //private void OnChanged(object sender, EventArgs e)
        //{
        //    Application.Current.Properties["Name"] = "Maria";
        //    Application.Current.SavePropertiesAsync();
        //}
    }
}