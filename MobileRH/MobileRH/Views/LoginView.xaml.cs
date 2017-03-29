using MobileRH.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileRH.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginViewModel ViewModel { get; set; }

        public LoginView()
        {
            InitializeComponent();

            ViewModel = new LoginViewModel();
            BindingContext = ViewModel;
        }
    }
}
