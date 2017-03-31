using MobileRH.Utils;
using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MobileRH.ViewsModel
{
    public class LoginViewModel : ViewModelBase
    {
        private int _codigoDaEmpresa;
        private string _usuario;
        private string _senha;

        public ICommand LoginCommand { get; }

        private IMessageService _servicoDeMensagem;
        private INavigationService _servicoDeNavegacao;

        public int CodigoDaEmpresa
        {
            get { return _codigoDaEmpresa; }
            set { _codigoDaEmpresa = value; OnPropertyChanged(); }
        }

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; OnPropertyChanged(); }
        }

        public string Senha
        {
            get { return _senha; }
            set { _senha = value; OnPropertyChanged(); }
        }

        public LoginViewModel()
        {
            this._servicoDeMensagem = DependencyService.Get<IMessageService>();
            this._servicoDeNavegacao = DependencyService.Get<INavigationService>();

            this.LoginCommand = new Command(ExecutarLogin);

            this.CodigoDaEmpresa = 192;
            this.Usuario = "thiago";
        }
        public void ExecutarLogin()
        {
            if (Usuario.ToUpper() == "THIAGO" && Senha == "123")
            {
                this._servicoDeNavegacao.GoToMainPage();
            }
            else
            {
                this._servicoDeMensagem.ShowMessage("Usuário ou senha incorretos.");
            }
        }
    }
}
