using Draw.Core.Business;
using Draw.Core.Data;
using Draw.Core.DTOs;
using Draw.Core.Entity;

namespace Draw.Business.Concrete;

public class SubTitleManager : GenericManager<SubTitle, SubTitleDTO>, ISubTitleService
{
	public SubTitleManager(IGenericRepository<SubTitle> genericRepository) : base(genericRepository)
	{
	}
}
