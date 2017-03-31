using MobileRH.Dados.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileRH.Dados.Repositories.Contracts
{
    public interface IRepository<T> where T: IEntity
    {
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllItems();
    }
}
