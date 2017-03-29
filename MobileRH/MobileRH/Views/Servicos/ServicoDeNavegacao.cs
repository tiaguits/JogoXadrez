using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.Views.Servicos
{
    public class ServicoDeNavegacao : IServicoDeNavegacao
    {        
        public ServicoDeNavegacao()
        {            
        }

        protected void ExibirPaginaNoDetalhe(Page pagina)
        {
            ((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(pagina);
        }

        protected void ExibirPaginaComoPrincipal(Page pagina)
        {
            App.Current.MainPage = pagina;
        }

        public void IrParaConfiguracoes()
        {
             ExibirPaginaNoDetalhe(ObterConfiguracoes());
        }

        public void IrParaLogin()
        {
            ExibirPaginaComoPrincipal(ObterLogin());
        }

        public void IrParaMinhasAprovacoes()
        {
            ExibirPaginaNoDetalhe(ObterMinhasAprovacoes());
        }

        public void IrParaMinhasSolicitacoes()
        {
            ExibirPaginaNoDetalhe(ObterMinhasSolicitacoes());
        }

        public void IrParaPaginaPrincipal()
        {
            ExibirPaginaComoPrincipal(ObterPaginaPrincipal());
        }

        public void IrParaSolicitacoesPendentes()
        {
            ExibirPaginaNoDetalhe(ObterSolicitacoesPendentes());
        }

        public Page ObterPaginaPrincipal()
        {
            return new MainPage();
        }

        public Page ObterConfiguracoes()
        {
            return new ConfiguracoesView();
        }

        public Page ObterLogin()
        {
            return new LoginView();
        }

        public Page ObterMinhasAprovacoes()
        {
            return new MinhasAprovacoesView();
        }

        public Page ObterMinhasSolicitacoes()
        {
            return new MinhasSolicitacoesView();
        }

        public Page ObterSolicitacoesPendentes()
        {
            return new SolicitacoesPendentesView();
        }

        public Type ObterTipoConfiguracoes()
        {
            return typeof(ConfiguracoesView);
        }

        public Type ObterTipoLogin()
        {
            return typeof(LoginView);
        }

        public Type ObterTipoMinhasAprovacoes()
        {
            return typeof(MinhasAprovacoesView);
        }

        public Type ObterTipoMinhasSolicitacoes()
        {
            return typeof(MinhasSolicitacoesView);
        }

        public Type ObterTipoPaginaPrincipal()
        {
            return typeof(MainPage);
        }

        public Type ObterTipoSolicitacoesPendentes()
        {
            return typeof(SolicitacoesPendentesView);
        }
    }
}
