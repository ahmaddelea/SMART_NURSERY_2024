using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace SMART_NURSERT_DATABASE_2024.COMMANDER
{
    public class CLS_COMMANDER<TEntity> : ICommander<TEntity> where TEntity : class
    {
        SMART_NURSERY_2024Entities CONTEXT = new SMART_NURSERY_2024Entities();
        //INSERT METHOD FOR INSERT DATA BY ENTITY
        public void INSERT_DATA(TEntity ENTITY)
        {
            CONTEXT.Set<TEntity>().Add(ENTITY);
            CONTEXT.SaveChanges();
        }
        //UPDATE METHOD FOR UPDATE DATA BY ENTITY
        public void UPDATE_DATA(TEntity ENTITY)
        {
            CONTEXT.Set<TEntity>().AddOrUpdate(ENTITY);
            CONTEXT.SaveChanges();
        }
        //DELETE METHOD FOR DELETE DATA BY ENTITY
        public void DELETE_DATA(TEntity ENTITY)
        {
            CONTEXT.Set<TEntity>().Remove(ENTITY);
            CONTEXT.SaveChanges();
        }
        //SELECT METHOD FOR SELECT ALL DATA BY ENTITY
        public IEnumerable<TEntity> GET_ALL()
        {
            return CONTEXT.Set<TEntity>().ToList();
        }
        //SELECT METHOD FOR SELECT ALL DATA BY ENTITY WHERE EXPRESSION
        public IEnumerable<TEntity> GET_BY(Expression<Func<TEntity, bool>> P)
        {
            return CONTEXT.Set<TEntity>().Where(P);
        }
        //SELECT METHOD FOR SELECT ALL DATA BY ENTITY WHERE EXPRESSION MAX ID
        public IEnumerable<TEntity> MAX_ID(Expression<Func<TEntity, bool>> P)
        {
            return CONTEXT.Set<TEntity>().Where(P);
        }
    }
}
