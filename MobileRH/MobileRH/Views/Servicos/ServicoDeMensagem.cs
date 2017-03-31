using MobileRH.ViewsModel.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Views.Servicos
{
    class ServicoDeMensagem : IMessageService
    {
        public async Task ShowMessage(string message)
        {
            await MobileRH.App.Current.MainPage.DisplayAlert("MobileRH", message, "ok");
        }
    }
}
