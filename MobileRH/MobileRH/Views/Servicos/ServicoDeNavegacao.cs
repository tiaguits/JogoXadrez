using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.Views.Servicos
{
    public class NavigationService : INavigationService
    {        
        public NavigationService()
        {            
        }

        public Type GetConfiguracoesViewType()
        {
            return typeof(ConfiguracoesView);
        }

        public Type GetLoginViewTypen()
        {
            return typeof(LoginView);
        }

        public Type GetMinhasAprovacoesViewType()
        {
            return typeof(MinhasAprovacoesView);
        }

        public Type GetMinhasSolicitacoesViewType()
        {
            return typeof(MinhasSolicitacoesView);
        }

        public Page GetConfiguracoesView()
        {
            return new ConfiguracoesView();
        }

        public Page GetLoginView()
        {
            return new LoginView();
        }

        public Page GetMinhasAprovacoesView()
        {
            return new MinhasAprovacoesView();
        }

        public Page GetMinhasSolicitacoesView()
        {
            return new MinhasSolicitacoesView();
        }

        public Page GetSolicitacoesPendentes()
        {
            return new SolicitacoesPendentesView();
        }

        public Page GetMainPageView()
        {
            return new MainPage();
        }

        public Type GetMainPageViewType()
        {
            return typeof(MainPage);
        }

        public Type GetSolicitacoesPendentesViewType()
        {
            return typeof(SolicitacoesPendentesView);
        }

        public void GoToConfiguracoes()
        {
            SetDetailPage(GetConfiguracoesView());
        }

        public void GoToLogin()
        {
            SetDetailPage(GetLoginView());
        }

        public void GoToMinhasAprovacoes()
        {
            SetDetailPage(GetMinhasAprovacoesView());
        }

        public void GoToMinhasSolicitacoes()
        {
            SetDetailPage(GetMinhasSolicitacoesView());
        }

        public void GoToMainPage()
        {
            SetMainPage(GetMainPageView());
        }

        public void GoToSolicitacoesPendentes()
        {
            SetDetailPage(GetSolicitacoesPendentes());
        }

        protected void SetDetailPage(Page page)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(page);
        }

        protected void SetMainPage(Page page)
        {
            App.Current.MainPage = page;
        }

    }
}
