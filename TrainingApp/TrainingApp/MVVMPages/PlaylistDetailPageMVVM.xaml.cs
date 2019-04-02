using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;
using TrainingApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.MVVMPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistDetailPageMVVM : ContentPage
	{
	    private PlaylistViewModel _playlist;

	    public PlaylistDetailPageMVVM(PlaylistViewModel playlist)
	    {
	        _playlist = playlist;

	        InitializeComponent();

	        title.Text = _playlist.Title;
	    }
    }
}