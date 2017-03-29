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
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _codigoDaEmpresa;
        private string _usuario;
        private string _senha;

        public ICommand LoginCommand { get; }

        private IServicoDeMensagem _servicoDeMensagem;
        private IServicoDeNavegacao _servicoDeNavegacao;

        public int CodigoDaEmpresa
        {
            get
            {
                return _codigoDaEmpresa;
            }
            set
            {
                if (_codigoDaEmpresa != value)
                {
                    _codigoDaEmpresa = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("CodigoDaEmpresa"));
                    }
                }
            }
        }

        public string Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                if (_usuario != value)
                {
                    _usuario = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Usuario"));
                    }
                }
            }
        }

        public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                if (_senha != value)
                {
                    _senha = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Senha"));
                    }
                }
            }
        }

        public LoginViewModel()
        {
            this._servicoDeMensagem = DependencyService.Get<IServicoDeMensagem>();
            this._servicoDeNavegacao = DependencyService.Get<IServicoDeNavegacao>();

            this.LoginCommand = new Command(ExecutarLogin);

            this.CodigoDaEmpresa = 192;
            this.Usuario = "thiago";
        }
        public void ExecutarLogin()
        {
            if (Usuario.ToUpper() == "THIAGO" && Senha == "123")
            {
                this._servicoDeNavegacao.IrParaPaginaPrincipal();
            }
            else
            {
                this._servicoDeMensagem.ExibirMensagem("Usuário ou senha incorretos.");
            }
        }
    }
}
