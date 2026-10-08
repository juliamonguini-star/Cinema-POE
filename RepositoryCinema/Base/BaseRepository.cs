using System;
using System.Collections.Generic;
using System.Text;
using RepositoryCinema.Context;

namespace RepositoryCinema.Base
{
    internal class BaseRepository<TypeEntity> : IBaseRepository<TypeEntity> where TypeEntity : BaseEntity
    {
        protected readonly MyDBContext _myDBContext;

        public BaseRepository(MyDBContext myDBContext)
        {
            _myDBContext = myDBContext;
            _myDBContext.Set<TypeEntity>();
        }

        public void Create(TypeEntity entity)
        {
            _myDBContext.Set<TypeEntity>().Add(entity);
            _myDBContext.SaveChanges();
        }

        public TypeEntity ReadbyId(int id)
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable(); //Query consulta
            return dbContext.ToList().Find(x => x.Id == id);
        }

        public IList<TypeEntity> ReadAll()
        {
            var dbContext = _myDBContext.Set<TypeEntity>().AsQueryable(); 
            return dbContext.ToList();
        }

        public void Update(TypeEntity entity)
        {
           _myDBContext.Entity(entity).State = EntityState.Modified;
           _myDBContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _myDBContext.Remove(ReadbyId(id));
            _myDBContext.SaveChanges();
        }
    }
}
