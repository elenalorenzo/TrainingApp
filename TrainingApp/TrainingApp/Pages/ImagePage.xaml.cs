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
	public partial class ImagePage : ContentPage
	{
	    private int _currentImageId;

	    public ImagePage()
	    {
	        InitializeComponent();

	        _currentImageId = 1;

	        LoadImage();
	    }

	    void LoadImage()
	    {
	        image.Source = new UriImageSource
	        {
	            Uri = new Uri($"http://lorempixel.com/1920/1080/city/{_currentImageId}"),
	            CachingEnabled = false
	        };
	    }

	    void Previous_Clicked(object sender, System.EventArgs e)
	    {
	        _currentImageId--;
	        if (_currentImageId == 0)
	            _currentImageId = 10;

	        LoadImage();
	    }

	    void Next_Clicked(object sender, System.EventArgs e)
	    {
	        _currentImageId++;
	        if (_currentImageId == 11)
	            _currentImageId = 1;

	        LoadImage();
	    }
    }
}