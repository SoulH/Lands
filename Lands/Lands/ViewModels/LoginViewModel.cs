using Lands.Data;
using Lands.Helpers;
using Lands.Models;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lands.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Commands
        public INavigation Navigation { get; set; }
        public ICommand LoginCommand { get; set; }
        #endregion

        #region Properties
        private string _user;
        public string User
        {
            get { return _user; }
            set { SetProperty(ref _user, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        private bool _remember;
        public bool Remember
        {
            get { return _remember; }
            set { SetProperty(ref _remember, value); }
        }
        #endregion

        public LoginViewModel(INavigation nav = null)
        {
            LoginCommand = new Command(Login);
            _user = string.Empty;
            _password = string.Empty;
            _remember = true;
            Navigation = nav;
            Message = string.Empty;
        }

        public async void Login()
        {
            IsBusy = true;
            Title = string.Empty;
            try
            {
                if (!string.IsNullOrEmpty(_user.Trim()))
                {
                    if (!string.IsNullOrEmpty(_password.Trim()))
                    {
                        //var context = new DbContext();
                        var usr = new { User = "Guest", Password = "12345", Email = "anemailname@example.com" };
                        //context.Users.Where(f => f.Name.Equals(_user) || f.Email.Equals(_user)).FirstOrDefault();

                        if (usr?.Password == _password)
                        {
                            Settings.IsLoggedIn = true;
                            await App.Current.MainPage.Navigation.PushAsync(new MainPage());
                            App.Current.MainPage.Navigation.RemovePage(Navigation.NavigationStack[0]);
                        }
                        else
                        {
                            Message = "Usuario o contraseña incorrecta";
                        }
                        IsBusy = false;
                    }
                    else
                    {
                        IsBusy = false;
                        Message = "La contraseña es requerido";
                    }

                }
                else
                {
                    IsBusy = false;
                    Message = "El email es requerido";
                }

            }
            catch (Exception e)
            {
                IsBusy = false;
                await App.Current.MainPage.DisplayAlert("Error de conexión", e.Message, "Ok");
            }
        }
    }
}
