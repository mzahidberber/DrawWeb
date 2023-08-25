using Draw.Core.Entity;

namespace Draw.Core.Data;

public interface IMainTitleRepository:IGenericRepository<MainTitle>
{
	Task<List<MainTitle>> GetAllMainTitleWithBaseTitleAsync();
}
