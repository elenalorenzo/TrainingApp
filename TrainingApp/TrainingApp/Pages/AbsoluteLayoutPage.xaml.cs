using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AbsoluteLayoutPage : ContentPage
	{
		public AbsoluteLayoutPage ()
		{
			InitializeComponent ();

		    //image.Source = ImageSource.FromResource("TrainingApp.Images.lotus-1205631_960_720.jpg");
		    //image.Source = ImageSource.FromUri(new Uri("https://cdn.pixabay.com/photo/2016/02/17/19/08/lotus-1205631_960_720.jpg"));
        }
	}
}