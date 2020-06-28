using System;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestAppUno.Shared.Content
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Login : Page
    {
        public string Password { get; set; }
        public string UserName { get; set; }

        public Login()
        {
            this.Password = "";
            UserName = "";
            this.InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var _userName = "TarikBeg";
            var _password = "123";

            if (_userName == name.Text && _password == password.Password)
            {
                Frame.Navigate(typeof(MainPage), true);
            }
            //else
            //{
            //     DisplayRect("This username/password combination isn't known",
            //        "Error logging you in",
            //        "OK");
            //}
        }
    }
}
