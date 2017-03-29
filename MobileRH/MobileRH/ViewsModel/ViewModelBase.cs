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
    public class ViewModelBase : INotifyPropertyChanged
    {
        private IServicoDeNavegacao _servicoDeNavegacao;
        private IServicoDeMensagem _servicoDeMensagem;

        public event PropertyChangedEventHandler PropertyChanged;

        public IServicoDeNavegacao ServicoDeNavegacao { get { return _servicoDeNavegacao; } }
        public IServicoDeMensagem ServicoDeMensagem { get { return _servicoDeMensagem; } }

        public ViewModelBase()
        {
            _servicoDeNavegacao = DependencyService.Get<IServicoDeNavegacao>();
            _servicoDeMensagem = DependencyService.Get<IServicoDeMensagem>();
        }
    }
}
