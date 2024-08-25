using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SMART_NURSERT_DATABASE_2024.COMMANDER
{
    interface ICommander<TEntity>
    {
        void INSERT_DATA(TEntity ENTITY);
        void UPDATE_DATA(TEntity ENTITY);
        void DELETE_DATA(TEntity ENTITY);
        IEnumerable<TEntity> GET_ALL();
        IEnumerable<TEntity> GET_BY(Expression<Func<TEntity, bool>> P);
        IEnumerable<TEntity> MAX_ID(Expression<Func<TEntity, bool>> P);
    }
}
