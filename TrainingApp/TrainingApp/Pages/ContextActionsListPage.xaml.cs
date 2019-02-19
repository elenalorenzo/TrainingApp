using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContextActionsListPage : ContentPage
	{
	    private ObservableCollection<Contact> _contacts;

		public ContextActionsListPage ()
		{
			InitializeComponent ();
		    _contacts = new ObservableCollection<Contact>
		    {
		        new Contact {Name = "Maria", ImageUrl = "http://lorempixel.com/100/100/people/2"},
		        new Contact {Name = "Elena", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "Even the proudest spirit..."},
		        new Contact {Name = "Lorenzo", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "Away"}
		    };

		    listView.ItemsSource = _contacts;
		}

	    void Call_Clicked(object sender, EventArgs e)
	    {
	        try
	        {
	            var menuItem = sender as MenuItem;
	            var contact = menuItem.CommandParameter as Contact;

	            DisplayAlert("Call", contact.Name, "OK");
	        }
	        catch (Exception exception)
	        {
	            DisplayAlert("Error", exception.Message, "OK");
	        }
	    }

	    void Delete_Clicked(object sender, EventArgs e)
	    {
	        try
	        {
	            var contact = (sender as MenuItem).CommandParameter as Contact;
	            _contacts.Remove(contact);

            }
	        catch (Exception exception)
	        {
	            DisplayAlert("Error", exception.Message, "OK");
	        }
	    }
    }
}