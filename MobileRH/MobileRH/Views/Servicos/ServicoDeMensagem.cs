using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Views.Servicos
{
    class ServicoDeMensagem : IServicoDeMensagem
    {
        public async Task ExibirMensagem(string mensagem)
        {
            await MobileRH.App.Current.MainPage.DisplayAlert("MobileRH", mensagem, "ok");
        }
    }
}
