using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturantSystemMaui.Models
{
    public class SignUpViewModel 
    {

        [PrimaryKey, AutoIncrement]
        int UserId { get; set; }    
        string Name { get; set; }
        string Email { get; set; }
        string Contact { get; set; }
        string Password { get; set; }

    }
}
