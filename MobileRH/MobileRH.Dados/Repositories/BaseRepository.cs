using MobileRH.Dados.Entities;
using MobileRH.Dados.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Dados.Repositories
{
    public class BaseRepository<T>: IRepository<T> where T: IEntity
    {
    }
}
