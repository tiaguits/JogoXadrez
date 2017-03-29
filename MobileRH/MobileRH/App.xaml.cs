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

            MainPage = new MainPage();
        }

        private void RegistrarDependencias()
        {
            DependencyService.Register<IServicoDeMensagem, ServicoDeMensagem>();
            DependencyService.Register<IServicoDeNavegacao, ServicoDeNavegacao>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
