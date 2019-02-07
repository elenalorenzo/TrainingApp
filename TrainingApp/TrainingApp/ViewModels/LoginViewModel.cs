using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace TrainingApp.ViewModels
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string _email;
        private string _password;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public ICommand SubmitCommand { protected set; get; }

        public LoginViewModel()
        {
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (_email != "xamarin@training.com" || _password != "password")
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
}
