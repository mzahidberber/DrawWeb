using Draw.Core.Data;
using Draw.Core.Entity;
using Draw.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace Draw.Data.Abstract;

public class EfGenericRepository<T> : IGenericRepository<T>
	where T : class, IEntity, new()
{
	protected readonly DrawContext _context;
	protected readonly DbSet<T> _dbSet;
	protected readonly IDbContextTransaction transaction;
	public EfGenericRepository(DrawContext context)
	{
		_context = context;
		_dbSet = _context.Set<T>();
		transaction = _context.Database.BeginTransaction();
	}
	public async Task AddAsync(T entity)
	{
		await _dbSet.AddAsync(entity);
	}

	public bool Commit(bool state = true)
	{
		_context.SaveChanges();
		if (state)
			transaction.Commit();
		else
			transaction.Rollback();

		Dispose();
		return true;
	}

	public async Task<bool> CommitAsync(bool state = true)
	{
		await _context.SaveChangesAsync();
		if (state)
			await transaction.CommitAsync();
		else
			await transaction.RollbackAsync();

		Dispose();
		return true;
	}
	public void Dispose()
	{
		_context.Dispose();
	}

	public void Delete(T entity)
	{
		_dbSet.Remove(entity);
	}


	public IQueryable<T> GetAll(Expression<Func<T, bool>>? filter = null)
	{
		if (filter != null) return _dbSet.Where(filter).AsQueryable();
		return _dbSet.AsQueryable();
	}

	public async Task<T> GetByIdAsync(int id)
	{
		var entity = await _dbSet.FindAsync(id);
		if (entity != null)
		{
			_context.Entry(entity).State = EntityState.Detached;
		}
		return entity;
	}

	public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter)
	{
		return _dbSet.Where(filter);
	}

	public void Update(T entity)
	{
		_context.Entry(entity).State = EntityState.Modified;

	}
}
