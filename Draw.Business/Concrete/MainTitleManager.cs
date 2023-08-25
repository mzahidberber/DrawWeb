using Draw.Business.Mapper;
using Draw.Core.Business;
using Draw.Core.Data;
using Draw.Core.DTOs;
using Draw.Core.Entity;

namespace Draw.Business.Concrete;

public class MainTitleManager : GenericManager<MainTitle, MainTitleDTO>, IMainTitleService
{
	private IMainTitleRepository _mainTitleDal;
	public MainTitleManager(IMainTitleRepository genericRepository) : base(genericRepository)
	{
		_mainTitleDal = genericRepository;
	}

	public async Task<Response<IEnumerable<MainTitleDTO>>> GetAllWithBaseTitleAsync()
	{
		var titles = await _mainTitleDal.GetAllMainTitleWithBaseTitleAsync();
		await _mainTitleDal.CommitAsync();
		var data = titles.Select(e => ObjectMapper.Mapper.Map<MainTitleDTO>(e));
		return Response<IEnumerable<MainTitleDTO>>.Success(data, 200);
	}
}
