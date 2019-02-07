using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
	    private int _index;
	    private readonly string[] _quotes = {
	        "\"Even the proudest spirit can be broken with love.\" \n   Neil Gaiman",
	        "\"The problems of failure are hard. The problems of success can be harder, because nobody warns you about them.\" \n   Neil Gaimam",
	        "\"First I got really grumpy, and then got very determined to write things that were so good that not even the stupidest most irritating gatekeeper alive could reject them.\" \n   Neil Gaiman",
	        "\"Everyone should know how to code a computer, because it teaches you how to think!.\" \n   Steve Jobs"
	    };

        public QuotesPage ()
		{
			InitializeComponent ();
		    currentQuote.Text = _quotes[_index];
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
	    {
	        _index++;
	        if (_index >= _quotes.Length)
	            _index = 0;

	        currentQuote.Text = _quotes[_index];
	    }
    }
}