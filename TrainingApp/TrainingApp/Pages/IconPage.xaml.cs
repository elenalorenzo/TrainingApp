using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IconPage : ContentPage
	{
		public IconPage ()
		{
			InitializeComponent ();

		    clockIcon.Image = FromFileOnPlatform("clock.png");
		}

	    private static FileImageSource FromFileOnPlatform(string resourceId)
	    {
	        switch (Device.RuntimePlatform)
	        {
	            case Device.UWP:
	                return (FileImageSource) ImageSource.FromFile($"Images/{resourceId}");

	            default:
	                return (FileImageSource) ImageSource.FromFile(resourceId);
	        }
	    }
    }
}