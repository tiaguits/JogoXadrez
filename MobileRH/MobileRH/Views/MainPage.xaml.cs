using MobileRH.Views;
using MobileRH.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPageViewModel ViewModel;

        public MainPage()
        {
            InitializeComponent();
            CreateMenu();

            Detail.Navigation.PushAsync(ViewModel.NavigationService.GetMinhasSolicitacoesView());
        }

        private void CreateMenu()
        {
            ViewModel = new MainPageViewModel();

            Menus.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                var menu = (MasterPageItem)e.Item;

                menu.Action();
                
                IsPresented = false;

                ((ListView)sender).SelectedItem = null;
            };

            Menus.ItemsSource = ViewModel.Menus;            
        }
    }
}
