

using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace ResturantSystemMaui.Models
{
    public partial class SigninViewModel : ObservableObject
    {
       

        [ObservableProperty]
        String name;

        [ObservableProperty]
        String password;


    }
}
