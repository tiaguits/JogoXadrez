using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.ViewsModel.Servicos
{
    public interface INavigationService
    {
        Type GetMainPageViewType();
        Type GetLoginViewTypen();
        Type GetMinhasSolicitacoesViewType();
        Type GetSolicitacoesPendentesViewType();
        Type GetMinhasAprovacoesViewType();
        Type GetConfiguracoesViewType();

        Page GetMainPageView();
        Page GetLoginView();
        Page GetMinhasSolicitacoesView();
        Page GetSolicitacoesPendentes();
        Page GetMinhasAprovacoesView();
        Page GetConfiguracoesView();

        void GoToMainPage();
        void GoToLogin();
        void GoToMinhasSolicitacoes();
        void GoToSolicitacoesPendentes();
        void GoToMinhasAprovacoes();
        void GoToConfiguracoes();
    }
}
