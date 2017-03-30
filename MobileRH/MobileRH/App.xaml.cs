using MobileRH.Views;
using MobileRH.Views.Servicos;
using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MobileRH
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegistrarDependencias();

            MainPage = new LoginView();
        }

        private void RegistrarDependencias()
        {
            DependencyService.Register<IServicoDeMensagem, ServicoDeMensagem>();
            DependencyService.Register<IServicoDeNavegacao, ServicoDeNavegacao>();
        }

        protected override void OnStart()
        {            
        }

        protected override void OnSleep()
        {            
        }

        protected override void OnResume()
        {
        }
    }
}
