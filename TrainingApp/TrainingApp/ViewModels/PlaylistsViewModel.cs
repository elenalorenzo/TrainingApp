using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using TrainingApp.Interfaces;
using TrainingApp.MVVMPages;
using Xamarin.Forms;

namespace TrainingApp.ViewModels
{
    public class PlaylistsViewModel : BaseViewModel
    {
        private PlaylistViewModel _selectedPlaylist;
        private readonly IPageService _pageService;

        public ICommand AddPlaylistCommand { get; private set; }
        public ICommand SelectPlayListCommand { get; private set; }
        public ObservableCollection<PlaylistViewModel> Playlists { get; private set; } = new ObservableCollection<PlaylistViewModel>();

        public PlaylistViewModel SelectedPlaylist
        {
            get => _selectedPlaylist;
            set => SetValue(ref _selectedPlaylist, value);
        }

        public PlaylistsViewModel(IPageService pageService)
        {
            _pageService = pageService;
            AddPlaylistCommand = new Command(AddPlaylist);
            SelectPlayListCommand = new Command<PlaylistViewModel>(async x => await SelectPlayList(x));
        }

        private void AddPlaylist()
        {
            var newPlaylist = "Playlist " + (Playlists.Count + 1);
            Playlists.Add(new PlaylistViewModel { Title = newPlaylist });
        }

        private async Task SelectPlayList(PlaylistViewModel playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;
            SelectedPlaylist = null;

            await _pageService.PushAsync(new PlaylistDetailPageMVVM(playlist));
            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}
