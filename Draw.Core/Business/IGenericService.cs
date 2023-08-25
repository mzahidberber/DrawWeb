using Draw.Core.DTOs;
using Draw.Core.Entity;
using System.Linq.Expressions;

namespace Draw.Core.Business;

public interface IGenericService<T,TDTO>
	where T : class,IEntity,new() where TDTO : class,IDTO,new()
{
	Task<Response<TDTO>> GetByIdAsync(int id);
	Task<Response<IEnumerable<TDTO>>> GetAllAsync();
	Task<Response<IEnumerable<TDTO>>> Where(Expression<Func<T, bool>> predicate);
	Task<Response<TDTO>> AddAsync(TDTO entity);
	Task<Response<NoDataDTO>> Remove(int id);
	Task<Response<NoDataDTO>> Update(TDTO entity, int id);
}
