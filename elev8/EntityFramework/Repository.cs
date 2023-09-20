using elev8.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace elev8.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        //Context context = new Context();

        public T Add(T model)
        {
            using (var context = new Context())
            {
                var addedEntity = context.Entry(model);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return model;
            }
        }

        public void Delete(T model)
        {
            using (var context = new Context())
            {
                var deletedEntity = context.Entry(model);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new Context())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            //return GetAll().Find(x=>x.Id==id);
            using (var context = new Context())
            {
                return context.Set<T>().Single(x => x.Id == id);
            }
        }

        public T Update(T model)
        {
            using (var context = new Context())
            {
                var updatedEntity = context.Entry(model);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return model;
            }
        }
    }
}
