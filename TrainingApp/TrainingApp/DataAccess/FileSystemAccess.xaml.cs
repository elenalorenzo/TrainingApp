using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.DataAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FileSystemAccess : ContentPage
	{
	    private readonly IFileSystem _fileSystem;

        public FileSystemAccess ()
		{
			InitializeComponent ();
		    _fileSystem = DependencyService.Get<IFileSystem>();
		    
		}

	    private async void Handle_TextChanged(object sender, TextChangedEventArgs e)
	    {
	        try
	        {
	            await _fileSystem.WriteTextAsync("TrainingApp.txt", editor.Text);
	            editorLabel.Text = "Text Saved";
	        }
	        catch (Exception exception)
	        {
	            editorLabel.Text = exception.Message;
            }
        }
	}
}