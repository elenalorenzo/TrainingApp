using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsPage : ContentPage
    {
        public FormsPage()
        {
            InitializeComponent();
            picker.ItemsSource = new List<string>
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday"
            };
        }

        private void Handle_Toggled(object sender, ToggledEventArgs e)
        {
            //label.IsVisible = e.Value;
            label.Text = e.Value ? "ON" : "OFF";
        }

        private void Handle_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //e.NewValue;
        }

        private void Handle_Completed(object sender, EventArgs e)
        {
            //passwordLabel.Text = "Completed";
        }

        private void Handle_TextChanged(object sender, TextChangedEventArgs e)
        {
            passwordLabel.Text = e.NewTextValue;
        }

        void Handle_PickerSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var picker = (Picker)sender;
                int selectedIndex = picker.SelectedIndex;

                if (selectedIndex != -1)
                {
                    pickerLabel.Text = (string)picker.ItemsSource[selectedIndex];
                }
            }
            catch (Exception exception)
            {
                DisplayAlert("Error", exception.Message, "OK");
            }
        }
    }
}