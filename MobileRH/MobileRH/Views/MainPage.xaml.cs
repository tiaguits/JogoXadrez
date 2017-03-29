using MobileRH.Views;
using MobileRH.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileRH.Views.PaginaPrincipal;

namespace MobileRH
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPageViewModel ViewModel;

        public MainPage()
        {
            InitializeComponent();
            CriarMenus();

            Detail.Navigation.PushAsync(ViewModel.ServicoDeNavegacao.ObterMinhasSolicitacoes());
        }

        private void CriarMenus()
        {
            ViewModel = new MainPageViewModel();

            Menus.ItemTapped += (object sender, ItemTappedEventArgs e) =>
            {
                var menu = (ItemDeMenu)e.Item;

                menu.Acao();
                
                IsPresented = false;

                ((ListView)sender).SelectedItem = null;
            };

            Menus.ItemsSource = ViewModel.Menus;            
        }
    }
}
