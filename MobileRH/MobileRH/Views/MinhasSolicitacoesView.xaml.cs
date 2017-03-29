using MobileRH.ViewsModel;
using MobileRH.ViewsModel.Servicos;
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
    public partial class MinhasSolicitacoesView : ContentPage
    {
        private MinhasSolicitacoesViewModel _viewModel;
        public MinhasSolicitacoesViewModel ViewModel { get; }

        public MinhasSolicitacoesView()
        {
            InitializeComponent();

            _viewModel = new MinhasSolicitacoesViewModel();
            BindingContext = _viewModel;
        }
    }
}
