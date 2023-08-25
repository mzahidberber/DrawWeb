using Draw.Core.Entity;
using System.Linq.Expressions;

namespace Draw.Core.Data;

public interface IGenericRepository<T>:IUnitOfWork
	where T : class,IEntity,new()
{
	IQueryable<T> GetAll(Expression<Func<T, bool>>? filter = null);
	IQueryable<T> GetWhere(Expression<Func<T, bool>> filter);
	Task<T> GetByIdAsync(int id);
	Task AddAsync(T entity);
	void Update(T entity);
	void Delete(T entity);

}
