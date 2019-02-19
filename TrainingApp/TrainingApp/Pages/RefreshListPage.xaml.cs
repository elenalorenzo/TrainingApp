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
	public partial class RefreshListPage : ContentPage
	{
	    private short listNumber = 0;
	    List<Contact> GetContacts()
	    {
	        switch (listNumber % 3)
	        {
                case 0:
                    return new List<Contact>
                    {
                        new Contact {Name = "Maria", ImageUrl = "http://lorempixel.com/100/100/people/2"},
                        new Contact {Name = "Elena", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "Even the proudest spirit..."},
                        new Contact {Name = "Lorenzo", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "Away"}
                    };

                case 1:
                    return new List<Contact>
                    {
                        new Contact {Name = "Maria", ImageUrl = "http://lorempixel.com/100/100/people/2"},
                        new Contact {Name = "Lorenzo", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "Away"}
                    };

                case 2:
                    return new List<Contact>
                    {
                        new Contact {Name = "Lorenzo", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "Away"}
                    };
            }

            return new List<Contact>();
        }

		public RefreshListPage ()
		{
			InitializeComponent ();
		    listView.ItemsSource = GetContacts();
        }

        void Handle_Refreshing(object sender, EventArgs e)
	    {

	        listNumber++;
	        if (listNumber == 3)
	            listNumber = 0;

            listView.ItemsSource = GetContacts();
	        listView.EndRefresh(); // another way: listView.IsRefreshing = false;
        }
    }
}