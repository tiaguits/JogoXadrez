using MobileRH.Dados.Entidades;
using MobileRH.Dados.Repositorios.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Dados.Repositorios
{
    public class RepositorioBase<T>: IRepositorio<T> where T: IEntidade
    {
    }
}
