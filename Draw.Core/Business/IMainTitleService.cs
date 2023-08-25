using Draw.Core.DTOs;
using Draw.Core.Entity;

namespace Draw.Core.Business;

public interface IMainTitleService:IGenericService<MainTitle,MainTitleDTO>
{
	Task<Response<IEnumerable<MainTitleDTO>>> GetAllWithBaseTitleAsync();
}
