using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryCinema.Base
{
    public interface IBaseRepository<TypeEntity> where TypeEntity : IBaseEntity
    {
        //MÉTODOS DO CRUD
        void Create(TypeEntity entity);
        TypeEntity ReadbyId(int id);
        IList<TypeEntity> ReadAll();
        void Update(TypeEntity entity);
        void Delete(int id);
    }
}
