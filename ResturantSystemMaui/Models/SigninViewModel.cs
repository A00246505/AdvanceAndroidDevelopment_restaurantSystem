

using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ResturantSystemMaui.Models
{
    public class SigninViewModel 
    {


        public Command LoginCommand { get; }
        private string name;

       public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string password;

        public string Password { get { return password; } set { password= value; } }
        public SigninViewModel() {


            LoginCommand = new Command(OnLogin);
            

        }


        private async void OnLogin()
        {
            if(name == "admin")
            {
                await Shell.Current.GoToAsync("//MenuItemAdmin");

            }
            else
            {
                await Shell.Current.GoToAsync("//MenuItemPage");
            }
            

        }


    }
}
