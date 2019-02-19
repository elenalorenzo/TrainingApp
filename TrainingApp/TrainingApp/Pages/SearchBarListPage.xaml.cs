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
	public partial class SearchBarListPage : ContentPage
	{
	    List<Contact> GetContacts(string searchtext = "") 
	    {
            var contacts = new List<Contact>
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

	        return string.IsNullOrWhiteSpace(searchtext) 
	            ? contacts 
	            : contacts.Where(x => x.Name.Contains(searchtext)).ToList();
	    }

	    public SearchBarListPage ()
		{
			InitializeComponent ();
		    listView.ItemsSource = GetContacts();
        }

        void Handle_TextChanged(object sender, TextChangedEventArgs e)
	    {
	        listView.ItemsSource = GetContacts(e.NewTextValue);
        }

    }
}