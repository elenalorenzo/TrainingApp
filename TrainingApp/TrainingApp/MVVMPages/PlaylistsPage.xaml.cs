using System;
using System.Collections.ObjectModel;
using TrainingApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.MVVMPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistsPage : ContentPage
	{
	    private readonly ObservableCollection<PlaylistViewModel> _playlists = new ObservableCollection<PlaylistViewModel>();

	    public PlaylistsPage()
	    {
	        InitializeComponent();
	    }

	    protected override void OnAppearing()
	    {
	        playlistsListView.ItemsSource = _playlists;

	        base.OnAppearing();
	    }

	    void OnAddPlaylist(object sender, System.EventArgs e)
	    {
	        var newPlaylist = "Playlist " + (_playlists.Count + 1);

	        _playlists.Add(new PlaylistViewModel { Title = newPlaylist });

	        this.Title = $"{_playlists.Count} Playlists";
	    }

	    void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
	    {
	        try
	        {
	            if (e.SelectedItem == null)
	                return;

	            var playlist = e.SelectedItem as PlaylistViewModel;
	            playlist.IsFavorite = !playlist.IsFavorite;

	            playlistsListView.SelectedItem = null;

	            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
            }
            catch (Exception exception)
	        {
	            DisplayAlert("Error", exception.Message, "OK");
            }
	    }
    }
}