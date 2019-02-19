using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages.Navigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
	    List<Contact> GetContacts()
	    {
	        return new List<Contact>
	        {
	            new Contact
	            {
	                Name = "Maria",
	                ImageUrl = "http://lorempixel.com/100/100/people/2"
	            },
	            new Contact
	            {
	                Name = "Elena",
	                ImageUrl = "http://lorempixel.com/100/100/people/4",
	                Status = "Even the proudest spirit..."
	            },
	            new Contact
	            {
	                Name = "Lorenzo",
	                ImageUrl = "http://lorempixel.com/100/100/people/5",
	                Status = "Away"
	            }
	        };
	    }

        public ContactsPage ()
		{
			InitializeComponent ();
		    listView.ItemsSource = GetContacts();
		}

	    async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        try
	        {
                if(e.SelectedItem == null)
                    return;

	            var contact = e.SelectedItem as Contact;
	            await Navigation.PushAsync(new ContactDetailPage(contact));
                //await Navigation.PushAsync(new ContactDetailPage {Contact = contact});
                //await Navigation.PushAsync(new ContactDetailPage {BindingContext = contact});

	            listView.SelectedItem = null;
	        }
            catch (Exception exception)
	        {
	            await DisplayAlert("Error", exception.Message, "OK");
	        }
	    }
    }
}