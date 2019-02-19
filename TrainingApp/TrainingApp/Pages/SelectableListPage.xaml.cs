using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectableListPage : ContentPage
	{
		public SelectableListPage ()
		{
			InitializeComponent ();

		    listView.ItemsSource = new List<Contact>
		    {
		        new Contact {Name = "Maria", ImageUrl = "http://lorempixel.com/100/100/people/2"},
		        new Contact {Name = "Elena", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "Even the proudest spirit..."},
		        new Contact {Name = "Lorenzo", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "Away"}
		    };
        }

	    void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        try
	        {
	            var contact = e.SelectedItem as Contact;
	            DisplayAlert("Selected", contact.Name, "OK");
            }
	        catch (Exception exception)
	        {
	            DisplayAlert("Error", exception.Message, "OK");
            }
        }

	    void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        try
	        {
	            var contact = e.Item as Contact;
	            DisplayAlert("Tapped", contact.Name, "OK");
	        }
	        catch (Exception exception)
	        {
	            DisplayAlert("Error", exception.Message, "OK");
	        }
        }

    }
}