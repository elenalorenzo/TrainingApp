using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainingTabbedPage : TabbedPage
    {
        public TrainingTabbedPage ()
        {
            InitializeComponent();

            //Content: this.Children
        }
    }
}