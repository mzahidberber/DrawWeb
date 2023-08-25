using Draw.Core.Business;
using Draw.Core.Data;
using Draw.Core.DTOs;
using Draw.Core.Entity;

namespace Draw.Business.Concrete;

public class BaseTitleManager : GenericManager<BaseTitle, BaseTitleDTO>, IBaseTitleService
{
	public BaseTitleManager(IGenericRepository<BaseTitle> genericRepository) : base(genericRepository)
	{
	}
}
