using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RelativeLayoutPage : ContentPage
	{
		public RelativeLayoutPage ()
		{
			InitializeComponent ();
            
      //      var layout = new RelativeLayout();
		    //Content = layout;

      //      var aquamarineBox = new BoxView{Color = Color.Aquamarine};
		    //layout.Children.Add(aquamarineBox, widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
		    //    heightConstraint: Constraint.RelativeToParent(parent => parent.Width * 3));

      //      var silverBox = new BoxView { Color = Color.Silver };
		    //layout.Children.Add(silverBox, 
		    //    yConstraint: Constraint.RelativeToView(aquamarineBox, (RelativeLayout, element) => element.Height + 20));
        }
	}
}