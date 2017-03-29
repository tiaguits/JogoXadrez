using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.ViewsModel.Servicos
{
    public interface IServicoDeNavegacao
    {
        Type ObterTipoPaginaPrincipal();
        Type ObterTipoLogin();
        Type ObterTipoMinhasSolicitacoes();
        Type ObterTipoSolicitacoesPendentes();
        Type ObterTipoMinhasAprovacoes();
        Type ObterTipoConfiguracoes();

        Page ObterPaginaPrincipal();
        Page ObterLogin();
        Page ObterMinhasSolicitacoes();
        Page ObterSolicitacoesPendentes();
        Page ObterMinhasAprovacoes();
        Page ObterConfiguracoes();

        void IrParaPaginaPrincipal();
        void IrParaLogin();
        void IrParaMinhasSolicitacoes();
        void IrParaSolicitacoesPendentes();
        void IrParaMinhasAprovacoes();
        void IrParaConfiguracoes();
    }
}
