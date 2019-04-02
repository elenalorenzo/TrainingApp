using TrainingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.MVVMPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistDetailPage : ContentPage
	{
	    private Playlist _playlist;

	    public PlaylistDetailPage(Playlist playlist)
	    {
	        _playlist = playlist;

	        InitializeComponent();

	        title.Text = _playlist.Title;
	    }
    }
}