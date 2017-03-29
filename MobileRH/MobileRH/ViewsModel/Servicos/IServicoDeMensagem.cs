using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.ViewsModel.Servicos
{
    public interface IServicoDeMensagem
    {
        Task ExibirMensagem(string mensagem);
    }
}
