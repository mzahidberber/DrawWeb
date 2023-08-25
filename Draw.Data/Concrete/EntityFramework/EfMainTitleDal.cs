using Draw.Core.Data;
using Draw.Core.Entity;
using Draw.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Draw.Data.Concrete.EntityFramework;

public class EfMainTitleDal : EfGenericRepository<MainTitle>, IMainTitleRepository
{
	public EfMainTitleDal(DrawContext context) : base(context)
	{
	}

	public async Task<List<MainTitle>> GetAllMainTitleWithBaseTitleAsync()
	{
		return await _dbSet
			.AsQueryable()
			.Include(x => x.BaseTitles)
			.ThenInclude(x => x.SubTitles)
			.ToListAsync() ?? throw new Exception("Entity Not Found");
	}
}
