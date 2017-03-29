using MobileRH.Views.PaginaPrincipal;
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
        private List<ItemDeMenu> _menus;
        public List<ItemDeMenu> Menus
        {
            get
            {
                return _menus;
            }
        }

        private Type _paginaInicial;
        public Type PaginaInicial
        {
            get
            {
                return _paginaInicial;
            }
        }

        public MainPageViewModel(): base()
        {            
            _paginaInicial = ServicoDeNavegacao.ObterTipoMinhasSolicitacoes();
            _menus = new List<ItemDeMenu>();

            DefinirMenus();
        }

        protected void DefinirMenus()
        {
            ItemDeMenu menuMinhasSolicitacoes = new ItemDeMenu();
            menuMinhasSolicitacoes.Titulo = "Minhas Solicitações";
            menuMinhasSolicitacoes.Icone = "minhassolicitacoes.png";
            menuMinhasSolicitacoes.Acao = () =>
            {
                ServicoDeNavegacao.IrParaMinhasSolicitacoes();
                return true;
            };

            _menus.Add(menuMinhasSolicitacoes);

            ItemDeMenu menuSolicitacoesPendentes = new ItemDeMenu();
            menuSolicitacoesPendentes.Titulo = "Solicitação Pendentes";
            menuSolicitacoesPendentes.Icone = "solicitacoespendentes.png";
            menuSolicitacoesPendentes.Acao = () =>
            {
                ServicoDeNavegacao.IrParaSolicitacoesPendentes();
                return true;
            };
            _menus.Add(menuSolicitacoesPendentes);

            ItemDeMenu menuMinhasAprovacoes = new ItemDeMenu();
            menuMinhasAprovacoes.Titulo = "Minhas Aprovações";
            menuMinhasAprovacoes.Icone = "minhasaprovacoes.png";
            menuMinhasAprovacoes.Acao = () =>
            {
                ServicoDeNavegacao.IrParaMinhasAprovacoes();
                return true;
            };
            _menus.Add(menuMinhasAprovacoes);

            ItemDeMenu menuConfiguracoes = new ItemDeMenu();
            menuConfiguracoes.Titulo = "Configurações";
            menuConfiguracoes.Icone = "configuracoes.png";
            menuConfiguracoes.Acao = () =>
            {
                ServicoDeNavegacao.IrParaConfiguracoes();
                return true;
            };
            _menus.Add(menuConfiguracoes);

            ItemDeMenu menuSair = new ItemDeMenu();
            menuSair.Titulo = "Sair";
            menuSair.Icone = "sair.png";
            menuSair.Acao = () =>
            {
                ServicoDeNavegacao.IrParaLogin();
                return true;
            };
            _menus.Add(menuSair);

        }
    }
}
