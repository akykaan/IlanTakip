using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessLayer.EntitiyFramework
{
	public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity> 
		where TContext:DbContext,new()
	{
		public void Add(TEntity entity)
		{
			using (TContext context = new TContext())
			{
				var add = context.Entry(entity);
				add.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(TEntity entity)
		{
			throw new NotImplementedException();
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(TEntity entity)
		{
			throw new NotImplementedException();
		}
	}
}
