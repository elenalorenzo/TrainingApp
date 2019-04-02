using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;
using TrainingApp.Services;
using TrainingApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.MVVMPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PlaylistsPageMVVM : ContentPage
	{
	    public PlaylistsPageMVVM()
	    {
	        ViewModel = new PlaylistsViewModel(new PageService());
	        InitializeComponent();
	    }

	    //protected override void OnAppearing()
	    //{
	    //    base.OnAppearing();
	    //}

        //void OnAddPlaylist(object sender, System.EventArgs e)
        //{
        //    try
        //    {
        //        (BindingContext as PlaylistsViewModel).AddPlaylist();
        //       }
        //       catch (Exception exception)
        //    {
        //        DisplayAlert("Error", exception.Message, "OK");
        //       }
        //}

        void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            try
            {
                ViewModel.SelectPlayListCommand.Execute(e.SelectedItem);
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "OK");
            }
        }

	    public PlaylistsViewModel ViewModel
	    {
            get => BindingContext as PlaylistsViewModel;
	        set => BindingContext = value;
	    }
    }
}