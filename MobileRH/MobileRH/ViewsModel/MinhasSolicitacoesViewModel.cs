using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileRH.ViewsModel
{
    public class MinhasSolicitacoesViewModel : ViewModelBase
    {
        private Command _atualizarCommand;
        private Command _novaSolicitacaoCommand;

        public Command AtualizarCommand { get { return _atualizarCommand; } }
        public Command NovaSolicitacaoCommand { get { return _novaSolicitacaoCommand; } }

        public MinhasSolicitacoesViewModel() : base()
        {
            _atualizarCommand = new Command(Atualizar);
            _novaSolicitacaoCommand = new Command(NovaSolicitacao);
        }

        protected void Atualizar()
        {
            MessageService.ShowMessage("Atualizar");
        }

        protected void NovaSolicitacao()
        {
            MessageService.ShowMessage("Nova Solicitação");
        }

    }
}
