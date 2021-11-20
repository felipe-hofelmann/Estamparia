using Estamparia.Aplication.Models.BaseModels;
using System.Collections.Generic;

namespace Estamparia.Aplication.Interfaces.IRepositorys.IBaseRepositorys
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        void Create(T model);
        List<T> Read();
        T Read(int id);
        void Update(T model);
        void Delete(int id);
    }
}
