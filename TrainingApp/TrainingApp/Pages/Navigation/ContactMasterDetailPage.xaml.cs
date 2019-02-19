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
	public partial class ContactMasterDetailPage : MasterDetailPage
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

        public ContactMasterDetailPage ()
		{
			InitializeComponent ();
		    listView.ItemsSource = GetContacts();
        }

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        try
	        {
	            var contact = e.SelectedItem as Contact;
                Detail = new NavigationPage(new ContactDetailPage(contact)); 
	            IsPresented = false; // IsMasterPresented
            }
	        catch (Exception exception)
	        {
	            DisplayAlert("Error", exception.Message, "OK");
	        }
	    }
    }
}