using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.ViewsModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private List<MasterPageItem> _menus;
        public List<MasterPageItem> Menus
        {
            get { return _menus; }
        }

        private Type _paginaInicial;
        public Type PaginaInicial
        {
            get { return _paginaInicial; }
        }

        public MainPageViewModel() : base()
        {
            _paginaInicial = NavigationService.GetMinhasSolicitacoesViewType();
            _menus = new List<MasterPageItem>();

            DefinirMenus();
        }

        protected void DefinirMenus()
        {
            MasterPageItem menuMinhasSolicitacoes = new MasterPageItem();
            menuMinhasSolicitacoes.Title = "Minhas Solicitações";
            menuMinhasSolicitacoes.Icon = "minhassolicitacoes.png";
            menuMinhasSolicitacoes.Action = () =>
            {
                NavigationService.GoToMinhasSolicitacoes();
                return true;
            };

            _menus.Add(menuMinhasSolicitacoes);

            MasterPageItem menuSolicitacoesPendentes = new MasterPageItem();
            menuSolicitacoesPendentes.Title = "Solicitação Pendentes";
            menuSolicitacoesPendentes.Icon = "solicitacoespendentes.png";
            menuSolicitacoesPendentes.Action = () =>
            {
                NavigationService.GoToSolicitacoesPendentes();
                return true;
            };
            _menus.Add(menuSolicitacoesPendentes);

            MasterPageItem menuMinhasAprovacoes = new MasterPageItem();
            menuMinhasAprovacoes.Title = "Minhas Aprovações";
            menuMinhasAprovacoes.Icon = "minhasaprovacoes.png";
            menuMinhasAprovacoes.Action = () =>
            {
                NavigationService.GoToMinhasAprovacoes();
                return true;
            };
            _menus.Add(menuMinhasAprovacoes);

            MasterPageItem menuConfiguracoes = new MasterPageItem();
            menuConfiguracoes.Title = "Configurações";
            menuConfiguracoes.Icon = "configuracoes.png";
            menuConfiguracoes.Action = () =>
            {
                NavigationService.GoToConfiguracoes();
                return true;
            };
            _menus.Add(menuConfiguracoes);

            MasterPageItem menuSair = new MasterPageItem();
            menuSair.Title = "Sair";
            menuSair.Icon = "sair.png";
            menuSair.Action = () =>
            {
                NavigationService.GoToLogin();
                return true;
            };
            _menus.Add(menuSair);

        }
    }
}
