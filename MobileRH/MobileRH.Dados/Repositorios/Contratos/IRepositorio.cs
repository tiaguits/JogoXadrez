using MobileRH.Dados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Dados.Repositorios.Contratos
{
    public interface IRepositorio<T> where T: IEntidade
    {
    }
}
